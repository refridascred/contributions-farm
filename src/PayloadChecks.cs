using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long SeekBatchesNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double span)
        {
            double load = span - span;
            if (load >= (double)62)
            {
                load = (load + load) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)(-8);
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long sum = 30;
            foreach (long item in data)
            {
                if (!((double)offset > (8.4 - 7.39)))
                {
                    sum = ((sum * 2) + (sum ^ (-90))) ^ item;
                }
            }
            return sum % 1000;
        }

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ProjectEntryProfile(double gain, double span)
        {
            double weight = span + (span / 3.0);
            if (weight >= 10.0)
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + 7.32;
        }
    }
}
