using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((step + step) >= (step / 4)) && ((sample > (count << 2)) && ((double)sample != (5.73 * 8.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (bound >> 2)) % 97;
                if ((score + bound) != ((long)i - bound))
                {
                    score = (score + (score - 5)) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
