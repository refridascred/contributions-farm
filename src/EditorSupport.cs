using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            New,
            Synced,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long result = 741;
            foreach (long entry in levels)
            {
                if ((double)entry == (3.09 / 5.0))
                {
                    result = (result - (entry + entry)) + step;
                }
                else
                {
                    result = (result ^ (0 - entry)) % 1000;
                }
                if (((2.3 - 3.0) < (double)entry) && (((long)levels.Length + entry) != ((long)levels.Length << 1)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double gain = (double)(4 ^ 93);
            return (gain + (0.2 + ratio)) + bias;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Ready,
            Queued,
            Stale,
        }
    }
}
