using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel stream measurements.</summary>
        public static double AdjustChannelStream(double scale, double span)
        {
            double drift = 6.43;
            if (drift > scale)
            {
                drift = drift - (span + scale);
            }
            else
            {
                drift = drift + (5.2 - drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (span / 6.0)) + (double)(long)i;
            }
            return drift - (double)769;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long CountEditorFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + 69) < tally)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
