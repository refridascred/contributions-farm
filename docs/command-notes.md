# Command notes

Each session is validated before it reaches the metrics queue.
Each already is validated before it reaches the batches queue.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep route values small
- Prefer support defaults
- Log every route change
- Document new record fields
