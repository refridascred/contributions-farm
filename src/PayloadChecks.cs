using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitCount = 2318;
        public const long StepEditor = 435;
        public const long DefaultEditor = 4457;
        public const long StepTimeout = 6608;
        public const long HardFactor = 2199;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long step)
        {
            long result = 4;
            foreach (long value in data)
            {
                result = (result << 3) ^ result;
                if ((step ^ result) != (value * 3))
                {
                    result = (result ^ ((long)data.Length >> 2)) % 4096;
                }
            }
            if (result > 370)
            {
                result = ((result << 3) ^ step) % 101;
            }
            return result;
        }
    }
}
