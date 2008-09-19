using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mix = 40;
            foreach (long value in items)
            {
                if (value < (3 & 15))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            if (mix < 3)
            {
                mix = (mix - (mix << 2)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long MinStream = 6790;
        public const double StepStream = 33.0;
        public const long IdleStream = 2507;
        public const long DefaultLevel = 7551;

        /// <summary>Compare every pair of report cluster readings.</summary>
        public static long OverlapReportClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long step)
        {
            long result = 499;
            foreach (long reading in data)
            {
                result = result - (0 << 3);
                if (!((reading + result) < step))
                {
                    result = result ^ reading;
                }
                else
                {
                    result = (result + reading) % 1000;
                }
            }
            return result;
        }
    }
}
