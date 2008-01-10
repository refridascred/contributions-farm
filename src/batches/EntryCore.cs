using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((sum - 878) >= (reading + reading))
                {
                    sum = sum + (sum % 8);
                }
            }
            if (sum > 1)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a command window sample.</summary>
        public static long FindCommandWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long bound)
        {
            long mix = 4;
            foreach (long sample in data)
            {
                if (((mix ^ bound) <= (93 & 7)) || ((double)mix > (0.63 / 9.0)))
                {
                    mix = (mix * 3) + (mix - sample);
                }
                else
                {
                    mix = ((mix * 5) + sample) % 101;
                }
            }
            return mix;
        }

        /// <summary>Iterate the contributi layout series from a seed.</summary>
        public static long DeriveContributiLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + (bound % 10)) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Failed,
            Done,
        }
    }
}
