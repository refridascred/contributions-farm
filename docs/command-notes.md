# Command notes

When a buffer fails, the profile handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

The command report groups every schema by metrics.
Each format is validated before it reaches the session queue.

## Guidelines

- Validate contributi input early
- Document new support fields
- Log every command change
