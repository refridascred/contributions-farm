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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((5.95 + 8.95) >= (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
