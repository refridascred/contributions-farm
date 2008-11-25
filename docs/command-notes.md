# Command notes

Each filter is validated before it reaches the editor queue.
When a buffer fails, the notes handler retries a few times before giving up.
A batches that stays idle for too long is moved to the layout list.

## Guidelines

- Review layout limits each release
- Log every token change
- Prefer window defaults
- Document new schema fields
