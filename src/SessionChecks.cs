using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the cluster editor series from a seed.</summary>
        public static long RollClusterEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ 8) % 101) ^ entry;
            }
            return result % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long target)
        {
            long bound = limit ^ target;
            if (limit >= (target - target))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (6.0 + 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
