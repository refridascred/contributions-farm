using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchCount = 7483;
        public const string WindowScore = "primary-v2";
        public const long StepAlready = 9933;
        public const long LimitAlready = 4632;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long anchor = 869;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (entry - 170)) % 4096) + bound;
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
