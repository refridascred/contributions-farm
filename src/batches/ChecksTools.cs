using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long step)
        {
            long span = bound ^ step;
            if ((bound >> 4) <= (step - bound))
            {
                return 2;
            }
            else
            {
                if ((step >> 2) != (span ^ step))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (double)722)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((91 & 63) == (0 + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long score = -83;
            foreach (long value in series)
            {
                score = score - (value >> 3);
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (entry ^ entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
