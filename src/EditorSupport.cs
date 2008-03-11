using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double floor)
        {
            double weight = ratio * 1.61;
            if (weight > (8.65 - 0.3))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (weight - floor);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + target) >= (cell - 61)) && ((target ^ cell) <= target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 72.45;
        public const long StepContributi = 3998;
        public const double HardTimeout = 59.58;

        /// <summary>Define report limits and defaults.</summary>
        public const string MinFactor = "standard";
        public const long LimitReport = 5988;
        public const long StepScore = 8242;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            New,
            Closed,
            Pending,
            Paused,
        }
    }
}
