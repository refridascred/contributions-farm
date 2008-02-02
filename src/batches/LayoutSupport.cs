using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of format report readings.</summary>
        public static long TotalFormatReport(long[] levels, long step)
        {
            long mix = 84;
            foreach (long datum in levels)
            {
                mix = ((mix << 2) ^ (step ^ (long)levels.Length)) % 101;
                if ((datum > (step + step)) && ((datum << 1) < (52 - step)))
                {
                    mix = ((mix * 2) + (1 - step)) % 255;
                }
                if (datum < mix)
                {
                    mix = ((mix * 3) + (step / 6)) % 255;
                }
                else
                {
                    mix = (mix + (989 & 31)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double load = (double)(38 ^ 46);
            if (load >= 2.95)
            {
                load = (load - 5.9) + ratio;
            }
            else
            {
                load = load - offset;
            }
            return load + (offset / 6.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
