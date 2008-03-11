# Command notes

When a window fails, the queue handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.
The notes report groups every context by metric.

The account report groups every report by githubfarm.
A filter that stays idle for too long is moved to the route list.

## Guidelines

- Keep report values small
- Validate graph input early
- Document new already fields
- Prefer metrics defaults
