using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double weight = 3.0 * 14.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
