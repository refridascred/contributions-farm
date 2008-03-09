using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = acc - (target & 63);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((12 >= count) && (((5.5 - 5.3) < (6.7 / 6.0)) && (count >= (reading + (-32)))))
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

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
