# Command notes

When a record fails, the entry handler retries a few times before giving up.
Each layout is validated before it reaches the batches queue.
When a support fails, the window handler retries a few times before giving up.

## Guidelines

- Prefer session defaults
- Document new notes fields
- Log every batch change
