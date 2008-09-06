using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values)
        {
            long sum = 12;
            foreach (long cell in values)
            {
                sum = sum - (cell & 31);
                if ((2.0 >= (double)sum) || ((double)sum >= (6.39 - 9.1)))
                {
                    sum = ((sum * 4) + sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long offset)
        {
            long diff = limit + offset;
            if ((diff - limit) != (6 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit & 1) >= 40)
                {
                    return 2;
                }
                else
                {
                    if (!((limit - limit) < (offset - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already commits sample.</summary>
        public static long LookupAlreadyCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
