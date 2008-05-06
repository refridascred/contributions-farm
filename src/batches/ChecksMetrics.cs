using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank layout order input into a small class.</summary>
        public static long GradeLayoutOrder(long step, long step2)
        {
            long slot = step ^ step2;
            if (!((step2 + step) != (2 / 9)))
            {
                return 2;
            }
            else
            {
                if ((slot < (step2 % 97)) || ((double)slot <= 4.9))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long floor)
        {
            long score = 9;
            foreach (long reading in values)
            {
                if (!((floor + score) >= (reading << 3)))
                {
                    score = (score - (long)values.Length) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Closed,
            New,
            Failed,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((38 + 527) <= (reading + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long limit)
        {
            long result = 23;
            foreach (long sample in data)
            {
                if ((sample ^ result) > (815 << 1))
                {
                    result = result ^ (limit * 5);
                }
            }
            if (result > 1)
            {
                result = result - limit;
            }
            return result;
        }
    }
}
