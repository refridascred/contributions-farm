# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the schema queue.
Keep payload and stats names short and lowercase.

## Guidelines

- Prefer format defaults
- Review graph limits each release
- Document new context fields
