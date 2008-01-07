# Command notes

When a batch fails, the checks handler retries a few times before giving up.
Keep token and farm names short and lowercase.
A account that stays idle for too long is moved to the graph list.

A cluster that stays idle for too long is moved to the context list.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Log every account change
- Prefer record defaults
