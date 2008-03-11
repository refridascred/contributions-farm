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

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a order graph pair into a bucket.</summary>
        public static long RankOrderGraph(long offset, long bound)
        {
            long span = offset + bound;
            if (((bound % 24) <= offset) || ((offset - bound) != (8 / 5)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((774 / 2) < (76 - bound)) && (offset > (span / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
