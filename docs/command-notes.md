# Command notes

Use route settings to tune how often cache data is refreshed.
The tools helpers are pure functions, so they are safe to call from any thread.
The cache report groups every buffer by editor.

When a notes fails, the stats handler retries a few times before giving up.
When a entry fails, the queue handler retries a few times before giving up.

## Guidelines

- Keep support values small
- Prefer format defaults
- Review payload limits each release
- Log every graph change
