using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mark = -46;
            foreach (long entry in readings)
            {
                mark = ((mark - (-975)) % 97) ^ entry;
            }
            if (mark > (-40))
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long target)
        {
            if ((target - offset) != (offset << 2))
            {
                return 4;
            }
            else
            {
                if ((target << 3) <= (-59))
                {
                    return 1;
                }
                else
                {
                    if (target <= (offset / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Closed,
            Ready,
        }
    }
}
