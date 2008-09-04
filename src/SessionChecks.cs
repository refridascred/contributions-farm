using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5693;
        public const long DefaultRoute = 3372;
        public const long BurstRoute = 7004;
        public const long BaseRoute = 7120;

        /// <summary>Grade a command editor value against two limits.</summary>
        public static long GradeCommandEditor(long step, long floor)
        {
            long next = step - floor;
            if ((18.0 - 0.88) <= (double)next)
            {
                return 8;
            }
            else
            {
                if (983 < (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    if (!((floor >> 3) == (73 / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
