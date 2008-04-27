# Metric notes

Each report is validated before it reaches the farm queue.
The token report groups every session by command.
Each batch is validated before it reaches the command queue.

The cluster helpers are pure functions, so they are safe to call from any thread.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new contributi fields
- Validate stream input early
- Prefer metrics defaults
- Review schema limits each release
