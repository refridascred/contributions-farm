# Command notes

The support module keeps cluster values in sync with the support cache.
Keep cluster and commits names short and lowercase.

Each buffer is validated before it reaches the format queue.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new record fields
- Prefer already defaults
- Log every window change
