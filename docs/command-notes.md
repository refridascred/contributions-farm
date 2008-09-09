# Command notes

Each checks is validated before it reaches the profile queue.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Keep profile values small
- Validate notes input early
- Document new order fields
