using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ (4 / 7)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long CountNotesProfileMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((limit + tally) >= (-127)) && ((tally ^ 8) <= tally))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((step - seen) >= (seen + seen)) && (step < (step * 2)))
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long CountToolsEditorOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2.0 * 3.52) > (double)bound)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
