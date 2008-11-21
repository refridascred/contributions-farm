using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftLevel = 2671;
        public const long MinAlready = 7557;
        public const long IdleAlready = 5446;
        public const double SoftRatio = 33.66;

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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 62.5;
        public const double BatchMetrics = 55.68;
        public const long BaseSize = 722;
        public const double HardMetrics = 25.83;
        public const long MinSize = 8177;
    }
}
