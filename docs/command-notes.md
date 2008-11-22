# Command notes

Each batches is validated before it reaches the support queue.
Run the layout check before changing any cluster limits.

Use entry settings to tune how often checks data is refreshed.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep buffer values small
- Document new queue fields
- Prefer cache defaults
- Review cache limits each release
