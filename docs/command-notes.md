# Command notes

When a record fails, the queue handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Keep entry values small
- Log every graph change
- Review report limits each release
- Prefer session defaults
