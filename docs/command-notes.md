# Command notes

Keep notes and cache names short and lowercase.
The window helpers are pure functions, so they are safe to call from any thread.

A metric that stays idle for too long is moved to the buffer list.
When a order fails, the githubfarm handler retries a few times before giving up.
The profile module keeps farm values in sync with the schema cache.

## Guidelines

- Keep githubfarm values small
- Prefer window defaults
- Document new graph fields
