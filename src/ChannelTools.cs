using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((origin < (-7)) && ((origin - hits) > (origin + hits)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer counter samples.</summary>
        public static long PairBufferCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 398;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (value + value)) % 4096;
            }
            if (acc < 560)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
