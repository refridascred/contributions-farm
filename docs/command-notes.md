# Command notes

A entry that stays idle for too long is moved to the window list.
The farm report groups every account by metrics.

The support helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the metric handler retries a few times before giving up.
Each already is validated before it reaches the window queue.

## Guidelines

- Log every stream change
- Prefer entry defaults
- Review cache limits each release
