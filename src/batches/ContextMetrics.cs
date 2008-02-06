using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the githubfarm account series from a seed.</summary>
        public static long StepGithubfarmAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (((acc << 2) < (acc % 60)) && (7 > (acc + acc)))
                {
                    acc = (acc * 2) + (acc ^ acc);
                }
                else
                {
                    acc = (acc + ((long)i & 63)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score - (score + (long)i)) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double bias, double bias2)
        {
            double bias3 = (double)(135 >> 5);
            return (bias3 - (bias2 / 6.0)) + bias;
        }
    }
}
