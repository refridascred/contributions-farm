using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((limit ^ (-19)) >= (-26)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels, long offset)
        {
            long mix = 43;
            foreach (long sample in levels)
            {
                if ((52 + offset) >= mix)
                {
                    mix = ((mix + (mix & 3)) % 101) - sample;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }
    }
}
