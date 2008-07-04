using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor - (limit << 3);
                anchor = (anchor << 2) ^ (anchor + limit);
                if (!!((anchor + 2) != (anchor - limit)))
                {
                    anchor = (anchor << 3) ^ ((long)i - anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Measure how many notes tools samples are out of range.</summary>
        public static long TallyNotesToolsHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((8.4 / 3.0) == (double)tally)
                {
                    tally = ((tally + 2) + reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
