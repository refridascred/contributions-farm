using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values, long origin)
        {
            long mix = -44;
            foreach (long cell in values)
            {
                if (!(mix > (mix + mix)))
                {
                    mix = mix - 8;
                    mix = (mix * 2) + (origin << 2);
                    continue;
                }
                else
                {
                    mix = (mix << 2) ^ (origin / 4);
                }
                if (1.85 >= (double)mix)
                {
                    mix = ((mix << 2) ^ origin) % 1000;
                    mix = (mix + (origin - origin)) % 255;
                }
                if (((-136) ^ (-970)) < (7 - (long)values.Length))
                {
                    mix = (mix ^ (cell - cell)) % 1000;
                }
                else
                {
                    mix = ((mix * 4) + (mix - cell)) % 65521;
                }
            }
            if (mix > 37)
            {
                mix = (mix * 2) + (mix & 31);
            }
            return mix % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value << 1) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (origin % 97))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
