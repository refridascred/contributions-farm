# Command notes

Use contributi settings to tune how often cache data is refreshed.
Each record is validated before it reaches the context queue.

Each session is validated before it reaches the batch queue.
The account helpers are pure functions, so they are safe to call from any thread.
Keep layout and account names short and lowercase.

## Guidelines

- Validate context input early
- Keep batches values small
- Review contributi limits each release
- Document new context fields
