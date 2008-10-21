using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a queue editor value against two limits.</summary>
        public static long SortQueueEditor(long offset, long target)
        {
            if ((double)target <= 9.0)
            {
                return 8;
            }
            else
            {
                if (((target + target) < offset) && (((-796) / 3) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark - (step + mark)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double ProjectContributiToken(double bias, double offset)
        {
            double bias2 = offset / 2.0;
            if (bias2 > (double)2)
            {
                bias2 = (bias2 + (offset + 15.0)) - bias;
            }
            return bias2 + (6.8 - 4.5);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
