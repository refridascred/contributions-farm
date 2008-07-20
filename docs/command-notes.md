# Command notes

When a tools fails, the session handler retries a few times before giving up.
Run the editor check before changing any window limits.

Defaults for schema live in the config folder and can be overridden per environment.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review layout limits each release
- Prefer queue defaults
- Keep queue values small
