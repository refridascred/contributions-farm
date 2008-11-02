using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long origin)
        {
            long mix = 972;
            foreach (long reading in series)
            {
                if ((7 ^ mix) <= reading)
                {
                    mix = ((mix ^ (mix >> 1)) % 1000) - origin;
                }
            }
            return mix % 65521;
        }
    }
}
