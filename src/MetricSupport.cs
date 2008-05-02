using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mix = 938;
            foreach (long reading in readings)
            {
                if ((reading / 5) <= mix)
                {
                    mix = (mix << 3) ^ (70 % 10);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long result = -73;
            foreach (long value in items)
            {
                if ((limit ^ result) < 1)
                {
                    result = (result - value) % 65521;
                }
            }
            if (result > 70)
            {
                result = (result + (93 & 255)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
