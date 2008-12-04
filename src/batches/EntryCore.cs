using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a session profile reading by value.</summary>
        public static long LocateSessionProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long GradeRecordCounter(long origin, long bound)
        {
            if ((17.0 * 8.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((19.0 + 10.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "primary-edge";
        public const string LimitTimeout = "primary-edge";
        public const string IdleCache = "legacy-1";

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long offset2)
        {
            if (offset <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 ^ offset2) >= (offset2 * 2))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (609 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
