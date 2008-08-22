# Command notes

When a channel fails, the counter handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.

Keep token and schema names short and lowercase.
A farm that stays idle for too long is moved to the command list.

## Guidelines

- Log every profile change
- Keep account values small
- Prefer contributi defaults
