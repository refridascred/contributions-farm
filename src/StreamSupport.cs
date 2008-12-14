using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            New,
            Draft,
            Active,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = 689;
            foreach (long item in series)
            {
                if (((item + item) < item) || ((total << 1) < item))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > (-79))
            {
                total = (total << 2) ^ (total - total);
            }
            return total;
        }
    }
}
