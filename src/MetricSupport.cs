using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items, long floor)
        {
            long mix = 372;
            foreach (long datum in items)
            {
                if ((datum << 1) > (mix / 7))
                {
                    mix = ((mix * 5) + (mix ^ floor)) % 4096;
                }
            }
            if (mix < 90)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long step2)
        {
            long delta = step - step2;
            if ((14.0 / 3.0) > (double)step)
            {
                return 7;
            }
            else
            {
                if (step2 < (delta % 7))
                {
                    return 5;
                }
                else
                {
                    if (step2 >= (step2 + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
