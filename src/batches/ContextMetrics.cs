using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long target2)
        {
            long edge = target + target2;
            if (edge >= target2)
            {
                return 8;
            }
            else
            {
                if ((edge >> 5) > (41 - target2))
                {
                    return 3;
                }
                else
                {
                    if ((target + 81) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 2) < (9 + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long bound)
        {
            long sum = 798;
            foreach (long entry in values)
            {
                sum = ((sum + bound) % 4096) + entry;
                if (!((double)sum != (double)121))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long TallyEditorNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (15 <= matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window notes value from a seed.</summary>
        public static long StepWindowNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
