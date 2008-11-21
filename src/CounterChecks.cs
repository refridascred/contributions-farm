using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 3977;
        public const double MinInterval = 11.05;
        public const long DefaultOrder = 9550;
        public const string RetryOrder = "local-1";
        public const long StepOrder = 8753;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Accumulate format metrics samples.</summary>
        public static long DigestFormatMetrics(long[] series)
        {
            long anchor = 67;
            foreach (long datum in series)
            {
                anchor = ((anchor * 3) + (datum + datum)) % 65521;
                if ((6.61 + 14.0) < (double)anchor)
                {
                    anchor = (anchor ^ (datum - anchor)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate record command samples.</summary>
        public static long CombineRecordCommand(long[] items, long floor)
        {
            long mark = 53;
            foreach (long value in items)
            {
                if ((floor + mark) >= value)
                {
                    mark = ((mark * 5) + floor) % 1000;
                }
                else
                {
                    mark = mark - floor;
                }
            }
            if (mark > 85)
            {
                mark = mark ^ ((-763) + mark);
            }
            return mark % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstInterval = 441;
        public const long HardChannel = 8526;
        public const string BatchChannel = "alpha-edge";
    }
}
