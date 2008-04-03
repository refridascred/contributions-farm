# Command notes

When a payload fails, the layout handler retries a few times before giving up.
Each order is validated before it reaches the schema queue.
The graph module keeps contributi values in sync with the queue cache.

## Guidelines

- Prefer session defaults
- Document new payload fields
- Review checks limits each release
