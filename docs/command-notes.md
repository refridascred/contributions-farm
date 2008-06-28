# Command notes

The window module keeps filter values in sync with the batch cache.
Use support settings to tune how often record data is refreshed.
When a record fails, the record handler retries a few times before giving up.

A format that stays idle for too long is moved to the metric list.
Each window is validated before it reaches the layout queue.

## Guidelines

- Keep schema values small
- Prefer profile defaults
- Log every report change
- Review window limits each release
