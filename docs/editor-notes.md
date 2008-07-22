# Editor notes

When a tools fails, the format handler retries a few times before giving up.
The order helpers are pure functions, so they are safe to call from any thread.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Prefer contributi defaults
- Validate batches input early
- Keep session values small
- Document new channel fields
