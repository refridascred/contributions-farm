# Command notes

The account module keeps cluster values in sync with the schema cache.
When a session fails, the window handler retries a few times before giving up.
A profile that stays idle for too long is moved to the stream list.

A command that stays idle for too long is moved to the metrics list.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer githubfarm defaults
- Validate contributi input early
- Keep batches values small
