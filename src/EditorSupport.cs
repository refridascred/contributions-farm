using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double load = scale;
            if (load > (offset + offset))
            {
                load = load - (double)26;
            }
            else
            {
                load = load + (double)2;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)3) + (double)(long)i;
            }
            return load + (offset + offset);
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length > (double)(-104))
                {
                    seen = ((seen + 3) + entry) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxInterval = 5693;
        public const double SoftAccount = 25.9;
        public const double BaseFactor = 19.76;
        public const string IdleCount = "strict-edge";
        public const string MaxAccount = "standard-1";

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
