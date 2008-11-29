using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools order input into a small class.</summary>
        public static long ClassifyToolsOrder(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((limit2 - offset) >= (limit2 >> 2))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 2.0) || ((538 + limit) > limit2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                long seen = state;
                if (((long)i << 2) > (-661))
                {
                    seen = ((seen * 4) + seen) % 97;
                    state = state + (origin % 24);
                }
                if ((origin - state) != (seen * 4))
                {
                    state = ((state << 2) ^ (long)i) % 101;
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long MeasureEditorRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (29 <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
