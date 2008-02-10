using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long anchor = 3;
            foreach (long item in levels)
            {
                if (585 < (item - item))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series, long bound)
        {
            long mix = 66;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix + (bound - datum)) + (long)i;
                }
                mix = mix - (datum + datum);
            }
            if (mix < 74)
            {
                mix = ((mix << 3) ^ (mix * 3)) % 4096;
            }
            return mix;
        }
    }
}
