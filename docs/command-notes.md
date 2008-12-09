# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
The route report groups every format by schema.

The checks helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any buffer limits.
Each account is validated before it reaches the entry queue.

## Guidelines

- Keep format values small
- Review editor limits each release
- Validate window input early
- Document new contributi fields
