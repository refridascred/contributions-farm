# Metric notes

The checks helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any counter limits.
Keep window and stats names short and lowercase.

## Guidelines

- Document new batch fields
- Log every farm change
- Keep report values small
- Prefer stream defaults
