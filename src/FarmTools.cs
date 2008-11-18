using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score + ((long)i * 3)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches stream values into a single score.</summary>
        public static long ScoreBatchesStream(long[] samples)
        {
            long carry = 884;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry * 2) + (carry * 3)) + (long)i;
                }
                carry = (carry << 2) ^ (4 ^ sample);
                carry = ((carry * 3) + sample) % 65521;
                if (4.12 <= (double)sample)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
