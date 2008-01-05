# Command notes

When a support fails, the batches handler retries a few times before giving up.
Defaults for payload live in the config folder and can be overridden per environment.
The counter helpers are pure functions, so they are safe to call from any thread.

A queue that stays idle for too long is moved to the payload list.
The profile module keeps format values in sync with the payload cache.

## Guidelines

- Prefer window defaults
- Document new schema fields
- Review already limits each release
- Keep graph values small
