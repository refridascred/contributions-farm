# Command notes

Keep farm and stream names short and lowercase.
A graph that stays idle for too long is moved to the entry list.

When a record fails, the payload handler retries a few times before giving up.
The metric helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any filter limits.

## Guidelines

- Review batch limits each release
- Document new order fields
- Prefer stream defaults
- Log every farm change
