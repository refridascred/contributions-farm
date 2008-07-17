# Command notes

When a support fails, the tools handler retries a few times before giving up.
The report report groups every metrics by metrics.

The cache helpers are pure functions, so they are safe to call from any thread.
The entry module keeps githubfarm values in sync with the entry cache.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Document new graph fields
- Prefer buffer defaults
- Keep command values small
- Log every farm change
