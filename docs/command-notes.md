# Command notes

When a editor fails, the editor handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.
A batch that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep route values small
- Prefer filter defaults
- Log every queue change
