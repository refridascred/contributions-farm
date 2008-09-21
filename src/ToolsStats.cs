using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token cache values into a single score.</summary>
        public static long ScoreTokenCache(long[] samples, long limit)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix * 4) + (limit & 63)) % 255;
                if ((mix + value) < (value + mix))
                {
                    break;
                }
            }
            if (mix < 60)
            {
                mix = (mix - (10 & 63)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (bound + carry)) ^ sample;
                carry = ((carry * 4) + 69) % 1000;
                carry = carry - (carry >> 4);
            }
            if (carry < 3)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long AuditChecksClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count ^ 883) >= datum) || (datum < 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 5220;
        public const string DefaultSize = "open-v2";
        public const long BatchRoute = 7293;
        public const string IdleScore = "staging";
    }
}
