# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Each format is validated before it reaches the payload queue.
Keep window and channel names short and lowercase.

The cluster report groups every profile by command.
Keep format and queue names short and lowercase.

## Guidelines

- Prefer route defaults
- Keep entry values small
- Validate context input early
- Log every context change
