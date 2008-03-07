# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Keep record and format names short and lowercase.
Keep command and batch names short and lowercase.

The order report groups every order by batches.
Use support settings to tune how often commits data is refreshed.
Each batch is validated before it reaches the checks queue.

## Guidelines

- Review counter limits each release
- Validate counter input early
- Keep order values small
- Prefer editor defaults
