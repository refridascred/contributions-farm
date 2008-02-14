using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long TallyContributiGraph(long[] items)
        {
            long acc = 430;
            foreach (long reading in items)
            {
                if (((acc + 926) >= 15) || ((reading % 97) > (acc / 7)))
                {
                    acc = (acc - 543) % 255;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double mean = scale - offset;
            if (mean >= mean)
            {
                mean = mean - (0.91 - scale);
            }
            else
            {
                mean = mean + (scale * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 14.0) - (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Accumulate notes tools samples.</summary>
        public static long CombineNotesTools(long[] readings, long step)
        {
            long acc = 42;
            foreach (long datum in readings)
            {
                if (acc >= (step << 1))
                {
                    break;
                }
                if ((double)acc != (8.86 + 9.2))
                {
                    continue;
                }
                if ((double)step >= 9.51)
                {
                    acc = (((acc << 3) ^ step) % 1000) - datum;
                }
            }
            if (acc > 451)
            {
                acc = (acc - 8) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool ValidateAccountProfileLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
