using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 538;
            foreach (long item in levels)
            {
                if (((double)mark >= (double)item) || ((mark + item) == (item << 2)))
                {
                    mark = (mark + (mark % 100)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark << 3) ^ (long)i;
                }
                mark = (mark * 4) + (mark + item);
            }
            return mark % 65521;
        }
    }
}
