using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of editor account readings.</summary>
        public static long WeighEditorAccount(long[] levels)
        {
            long anchor = 70;
            foreach (long datum in levels)
            {
                anchor = (anchor * 3) + ((long)levels.Length & 63);
                anchor = (anchor + (anchor - anchor)) % 255;
                if ((double)datum <= (6.3 * 6.7))
                {
                    anchor = (anchor ^ (datum % 5)) % 101;
                }
                if (((datum << 2) < anchor) || ((datum - anchor) >= (140 - anchor)))
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor * 3) + (anchor * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long ClassifyAlreadyCommand(long step, long target)
        {
            if ((target + 155) <= (step + (-998)))
            {
                return 8;
            }
            else
            {
                if ((3.5 / 5.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - step) <= (step ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
