using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate context account samples.</summary>
        public static long TallyContextAccount(long[] levels, long step)
        {
            long mix = 6;
            foreach (long cell in levels)
            {
                if ((double)cell > (18.0 - 3.8))
                {
                    break;
                }
                mix = (mix - step) % 65521;
                if (((step << 3) != (step & 63)) || (cell < (step ^ step)))
                {
                    break;
                }
            }
            if (mix < 15)
            {
                mix = ((mix * 5) + (mix + step)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - ((-868) >> 1)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long carry = 14;
            foreach (long reading in series)
            {
                carry = ((((carry * 4) + (carry / 5)) % 97) - reading) - bound;
            }
            return carry % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double ratio = (bias + bias) - (13.0 / 3.0);
            if (ratio < (ratio * 7.18))
            {
                ratio = ratio - (double)659;
            }
            else
            {
                ratio = ratio - (bias * 0.63);
            }
            return ratio - (bias2 / 7.0);
        }
    }
}
