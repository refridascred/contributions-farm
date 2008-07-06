using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total - bound) - (long)i2;
                    total = total - (767 - total);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a queue window reading.</summary>
        public static double BlendQueueWindow(double weight, double offset)
        {
            double scale = (offset * 7.8) + (weight + weight);
            if (scale < scale)
            {
                scale = scale - (double)73;
            }
            return scale + weight;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((hits - (-6)) > (hits % 16)) || ((double)hits < (0.36 + 8.54)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Match up tools format samples.</summary>
        public static long MatchToolsFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
