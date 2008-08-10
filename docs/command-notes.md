# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Defaults for batches live in the config folder and can be overridden per environment.

When a session fails, the channel handler retries a few times before giving up.
Use format settings to tune how often window data is refreshed.
Each record is validated before it reaches the token queue.

## Guidelines

- Keep editor values small
- Document new format fields
- Validate route input early
