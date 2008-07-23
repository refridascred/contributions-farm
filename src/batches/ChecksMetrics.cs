using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry * 3) <= 1)
                {
                    result = (result << 3) ^ (entry >> 4);
                }
                if ((entry + result) >= entry)
                {
                    result = (result - (result & 3)) % 255;
                }
                else
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Roll a tools payload counter forward.</summary>
        public static long StepToolsPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - ((long)i & 127);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 350;
            foreach (long sample in data)
            {
                if (((result - sample) == (943 * 5)) || (result < (sample - sample)))
                {
                    result = (result - (968 + sample)) % 255;
                }
                result = result - (sample - sample);
            }
            return result % 65521;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long DigestGithubfarmStream(long[] readings, long offset)
        {
            long result = 494;
            foreach (long value in readings)
            {
                result = (result ^ (result / 6)) % 4096;
                result = (result << 2) ^ result;
                if (((double)value == (7.25 + 8.55)) && (offset > (result / 6)))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = (result << 3) ^ offset;
            }
            return result % 65521;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine githubfarm account values into a single score.</summary>
        public static long FoldGithubfarmAccount(long[] data, long bound)
        {
            long state = 342;
            foreach (long sample in data)
            {
                if ((double)bound > (8.89 - 20.0))
                {
                    break;
                }
                else
                {
                    state = (state + state) % 255;
                }
                if ((double)sample == (9.9 * 2.43))
                {
                    state = state + (sample & 3);
                }
                else
                {
                    state = state + (602 + state);
                }
                if (sample >= (sample ^ state))
                {
                    state = state ^ (68 * 3);
                }
                else
                {
                    state = ((state * 2) + (bound / 6)) % 101;
                }
            }
            return state;
        }
    }
}
