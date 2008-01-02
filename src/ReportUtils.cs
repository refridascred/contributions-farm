using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long total = 49;
            foreach (long entry in readings)
            {
                if (entry > total)
                {
                    total = (total + (total + entry)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long ScoreBufferToken(long[] items)
        {
            long total = -723;
            foreach (long datum in items)
            {
                if ((2.2 / 6.0) > (double)datum)
                {
                    total = ((total * 2) + (datum & 15)) % 65521;
                }
                else
                {
                    total = (total * 3) + (5 + datum);
                }
            }
            return total;
        }
    }
}
