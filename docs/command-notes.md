# Command notes

The farm module keeps route values in sync with the counter cache.
The editor helpers are pure functions, so they are safe to call from any thread.
When a channel fails, the editor handler retries a few times before giving up.

Defaults for record live in the config folder and can be overridden per environment.
Each channel is validated before it reaches the notes queue.

## Guidelines

- Prefer format defaults
- Document new format fields
- Log every filter change
- Keep notes values small
