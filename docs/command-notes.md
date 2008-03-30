# Command notes

The support report groups every batch by record.
The profile helpers are pure functions, so they are safe to call from any thread.

The account helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the cluster queue.

## Guidelines

- Validate checks input early
- Prefer layout defaults
- Document new order fields
