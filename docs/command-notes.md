# Command notes

The queue report groups every context by counter.
The cache helpers are pure functions, so they are safe to call from any thread.
The record helpers are pure functions, so they are safe to call from any thread.

The schema helpers are pure functions, so they are safe to call from any thread.
The token report groups every batch by payload.

## Guidelines

- Log every format change
- Document new graph fields
- Keep profile values small
- Prefer account defaults
