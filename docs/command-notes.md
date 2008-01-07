# Command notes

Run the stream check before changing any queue limits.
The farm helpers are pure functions, so they are safe to call from any thread.
When a command fails, the counter handler retries a few times before giving up.

## Guidelines

- Validate editor input early
- Keep batches values small
- Prefer route defaults
