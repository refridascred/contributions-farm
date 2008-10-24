using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                if (datum <= (score + datum))
                {
                    score = score ^ ((long)series.Length + 48);
                }
                else
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 652)
            {
                score = (score * 4) + (-42);
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result * 2) >= (long)i) || ((step ^ (long)i) >= (step >> 2)))
                {
                    result = result ^ (result + step);
                    result = ((result << 2) ^ (step / 9)) % 1000;
                    break;
                }
                if (((796 + result) != (57 - step)) || ((result * 3) < result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((state ^ state) > (seed % 12))
                {
                    state = (state - (state << 1)) % 101;
                }
                else
                {
                    state = (state ^ ((long)i % 60)) % 255;
                    state = (state + ((long)i & 63)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Pending,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
