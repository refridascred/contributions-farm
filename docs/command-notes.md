# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
When a layout fails, the format handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep commits values small
- Log every queue change
- Prefer report defaults
