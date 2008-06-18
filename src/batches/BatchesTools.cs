using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long origin)
        {
            if (6 <= (origin / 5))
            {
                return 2;
            }
            else
            {
                if (((target >> 2) <= target) && ((origin * 2) >= target))
                {
                    return 3;
                }
                else
                {
                    if ((7 >> 2) < (origin / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 7) > 56)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) <= (sample << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
