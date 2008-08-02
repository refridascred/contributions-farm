using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of counter channel entries.</summary>
        public static long ScoreCounterChannel(long[] samples, long floor)
        {
            long result = 11;
            foreach (long reading in samples)
            {
                result = ((((result * 3) + (result >> 2)) % 97) - reading) + floor;
            }
            return result;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] series, long seed)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + ((long)series.Length + cell)) % 101) - seed;
            }
            return mix;
        }
    }
}
