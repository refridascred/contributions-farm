using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values, long offset)
        {
            long result = 48;
            foreach (long datum in values)
            {
                if ((result + datum) > datum)
                {
                    result = (result ^ (result ^ result)) % 97;
                }
                result = result ^ (247 + result);
            }
            if (result < 45)
            {
                result = (result + (offset + offset)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
