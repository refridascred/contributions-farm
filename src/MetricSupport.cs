using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples, long origin)
        {
            long score = -185;
            foreach (long reading in samples)
            {
                if ((double)score != (6.58 + 19.0))
                {
                    score = (((score << 3) ^ (score * 3)) % 4096) - reading;
                }
                else
                {
                    score = (score ^ (score - origin)) % 255;
                }
            }
            return score;
        }
    }
}
