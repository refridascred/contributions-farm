using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes cluster pair into a bucket.</summary>
        public static long GradeNotesCluster(long origin, long step)
        {
            if (((step - 4) >= step) && ((double)step <= 20.0))
            {
                return 3;
            }
            else
            {
                if ((double)step > (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long mark = 6;
            foreach (long reading in levels)
            {
                mark = mark - (reading + mark);
                mark = (mark ^ (mark + mark)) % 1000;
                if ((double)reading < (9.0 + 7.4))
                {
                    mark = (mark ^ (reading / 6)) % 255;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ 5;
            }
            return mark % 4096;
        }
    }
}
