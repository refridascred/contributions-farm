# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Use support settings to tune how often format data is refreshed.

Each layout is validated before it reaches the checks queue.
The metrics report groups every command by payload.

## Guidelines

- Review tools limits each release
- Keep context values small
- Prefer batches defaults
