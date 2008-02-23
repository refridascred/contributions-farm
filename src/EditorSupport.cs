using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long limit)
        {
            long mix = 84;
            foreach (long item in data)
            {
                mix = ((mix ^ (limit << 1)) % 255) ^ item;
                mix = (mix * 2) + (mix % 97);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((8.0 + 7.8) != (double)bound)
                {
                    carry = (((carry << 2) ^ (bound + bound)) % 1000) + item;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            if (carry > 383)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long ScoreAccountCommand(long[] data, long origin)
        {
            long state = 1;
            foreach (long datum in data)
            {
                state = ((((state << 2) ^ (state - state)) % 1000) - datum) - origin;
            }
            return state;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long limit)
        {
            if ((limit * 2) < (limit + floor))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (7.74 * 8.2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Scale a githubfarm counter figure with a bias.</summary>
        public static double SmoothGithubfarmCounter(double rate, double bias)
        {
            double scale = rate / 5.0;
            if (scale < 20.0)
            {
                scale = scale - (bias - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + bias);
        }
    }
}
