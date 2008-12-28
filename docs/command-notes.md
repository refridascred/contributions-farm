# Command notes

Keep graph and filter names short and lowercase.
Each graph is validated before it reaches the record queue.

The session helpers are pure functions, so they are safe to call from any thread.
Keep context and schema names short and lowercase.
The buffer report groups every metrics by metric.

## Guidelines

- Keep stats values small
- Review command limits each release
- Validate commits input early
