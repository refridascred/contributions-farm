# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
A format that stays idle for too long is moved to the stream list.

Use metric settings to tune how often commits data is refreshed.
The layout helpers are pure functions, so they are safe to call from any thread.
A batch that stays idle for too long is moved to the format list.

## Guidelines

- Review report limits each release
- Document new batch fields
- Prefer format defaults
- Keep payload values small
