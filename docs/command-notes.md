# Command notes

Each cache is validated before it reaches the stream queue.
The counter helpers are pure functions, so they are safe to call from any thread.

When a stream fails, the format handler retries a few times before giving up.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Log every counter change
- Document new session fields
- Validate token input early
