using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long anchor = 56;
            foreach (long entry in series)
            {
                if (anchor <= (entry ^ entry))
                {
                    anchor = (anchor ^ (8 + anchor)) % 101;
                }
            }
            if (anchor < 10)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((double)seen < (6.4 / 2.0)) && ((datum + seen) < (-618))) || (402 >= (datum / 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Done,
            Pending,
            Queued,
        }
    }
}
