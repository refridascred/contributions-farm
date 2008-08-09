# Command notes

Run the layout check before changing any buffer limits.
Keep batch and counter names short and lowercase.
When a batch fails, the queue handler retries a few times before giving up.

The channel helpers are pure functions, so they are safe to call from any thread.
Each record is validated before it reaches the schema queue.
Keep profile and checks names short and lowercase.

## Guidelines

- Prefer tools defaults
- Review account limits each release
- Log every session change
