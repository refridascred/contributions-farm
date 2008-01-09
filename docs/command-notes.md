# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the batches queue.
Keep context and format names short and lowercase.

## Guidelines

- Review metric limits each release
- Keep notes values small
- Log every support change
- Prefer filter defaults
