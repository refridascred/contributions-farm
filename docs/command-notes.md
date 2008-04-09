# Command notes

When a schema fails, the entry handler retries a few times before giving up.
Keep token and editor names short and lowercase.

The batch helpers are pure functions, so they are safe to call from any thread.
Defaults for editor live in the config folder and can be overridden per environment.

## Guidelines

- Log every channel change
- Validate stream input early
- Review commits limits each release
- Keep command values small
