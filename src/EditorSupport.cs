using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double mean = bias;
            if (mean < (bias / 3.0))
            {
                mean = mean - (double)21;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - (double)40;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 8310;
        public const string LimitInterval = "latest";
        public const double HardFilter = 58.94;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Validate stream githubfarm readings against a bound.</summary>
        public static bool GuardStreamGithubfarmBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                if ((mix < (datum >> 5)) && ((mix / 3) != (datum & 15)))
                {
                    mix = mix ^ (mix >> 3);
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ ((long)values.Length + mix)) % 97;
            }
            return mix;
        }
    }
}
