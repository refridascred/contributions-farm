using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                anchor = ((anchor + anchor) % 65521) - datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema payload readings.</summary>
        public static long DigestSchemaPayload(long[] data)
        {
            long sum = 929;
            foreach (long value in data)
            {
                sum = (sum * 4) + 534;
                if ((double)value != (0.5 * 12.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of editor route readings.</summary>
        public static long FoldEditorRoute(long[] series)
        {
            long mix = 16;
            foreach (long reading in series)
            {
                if (!((mix / 5) >= mix))
                {
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ reading) % 97;
            }
            if (mix > (-358))
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
