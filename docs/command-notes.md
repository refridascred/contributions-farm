# Command notes

The order report groups every route by batch.
Each checks is validated before it reaches the metric queue.
The stream helpers are pure functions, so they are safe to call from any thread.

Run the payload check before changing any notes limits.
The checks report groups every command by window.

## Guidelines

- Keep report values small
- Document new cache fields
- Review format limits each release
- Prefer account defaults
