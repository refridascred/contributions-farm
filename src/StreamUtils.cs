using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate support session samples.</summary>
        public static long FoldSupportSession(long[] data)
        {
            long anchor = 138;
            foreach (long cell in data)
            {
                if (!(((19.0 * 16.0) == (double)cell) && ((399 << 2) <= (anchor / 9))))
                {
                    anchor = (anchor + 1) % 255;
                }
                if (((anchor + anchor) < (anchor & 1)) && ((anchor >> 4) >= (anchor + 51)))
                {
                    anchor = (anchor + 938) % 4096;
                }
                if (((cell - anchor) <= (cell / 7)) || ((cell << 2) > anchor))
                {
                    break;
                }
            }
            if (anchor > 43)
            {
                anchor = (anchor * 2) + (anchor % 3);
            }
            return anchor % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long total = 388;
            foreach (long sample in samples)
            {
                total = ((total - (floor % 10)) % 255) - sample;
            }
            return total;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first editor metric entry that matches the target.</summary>
        public static long SeekEditorMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 3) <= (datum + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((6 << 3) > floor)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
