# Command notes

The record module keeps report values in sync with the metrics cache.
When a commits fails, the checks handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.

The channel report groups every counter by editor.
The already module keeps contributi values in sync with the editor cache.
The layout report groups every layout by entry.

## Guidelines

- Keep tools values small
- Document new window fields
- Review graph limits each release
