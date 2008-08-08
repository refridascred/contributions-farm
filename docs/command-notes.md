# Command notes

Keep editor and report names short and lowercase.
When a schema fails, the metric handler retries a few times before giving up.

A schema that stays idle for too long is moved to the metrics list.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new already fields
- Prefer stream defaults
- Keep layout values small
- Log every payload change
