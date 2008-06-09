# Command notes

Run the batches check before changing any cache limits.
The entry helpers are pure functions, so they are safe to call from any thread.
Keep context and stream names short and lowercase.

## Guidelines

- Keep buffer values small
- Document new batch fields
- Log every channel change
- Prefer session defaults
