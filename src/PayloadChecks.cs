using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up report notes samples.</summary>
        public static long CompareReportNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double weight = (double)588;
            if (weight <= (gain + gain))
            {
                weight = (weight - (double)12) + span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Fold a list of account queue readings.</summary>
        public static long FoldAccountQueue(long[] readings)
        {
            long mix = 498;
            foreach (long entry in readings)
            {
                if (entry < mix)
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = mix + 692;
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (18.0 - scale)) + (double)(long)i;
            }
            return bias - (scale - offset);
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
