# Command notes

The schema module keeps context values in sync with the checks cache.
The window helpers are pure functions, so they are safe to call from any thread.
The batches report groups every metric by entry.

Run the layout check before changing any notes limits.
The counter helpers are pure functions, so they are safe to call from any thread.
Each graph is validated before it reaches the context queue.

## Guidelines

- Validate schema input early
- Keep format values small
- Prefer route defaults
- Review filter limits each release
