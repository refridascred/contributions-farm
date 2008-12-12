# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The counter helpers are pure functions, so they are safe to call from any thread.

Each counter is validated before it reaches the metrics queue.
Defaults for stream live in the config folder and can be overridden per environment.
When a commits fails, the payload handler retries a few times before giving up.

## Guidelines

- Prefer channel defaults
- Keep support values small
- Document new session fields
- Review commits limits each release
