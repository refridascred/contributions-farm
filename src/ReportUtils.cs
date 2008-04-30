using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long state = -34;
            foreach (long datum in series)
            {
                if (!((double)floor > 15.0))
                {
                    state = state + datum;
                }
                else
                {
                    state = (state + (datum ^ 45)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long GradeProfileEditor(long origin, long seed)
        {
            if (((seed >> 5) > (origin + origin)) || ((6.86 * 17.0) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((seed - origin) > (seed << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many channel already samples are out of range.</summary>
        public static long TallyChannelAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) < 7) || (((hits % 8) == (hits >> 5)) || ((datum / 5) != (datum * 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
