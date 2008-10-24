# Command notes

Keep profile and record names short and lowercase.
Each schema is validated before it reaches the checks queue.

Each entry is validated before it reaches the notes queue.
When a entry fails, the buffer handler retries a few times before giving up.
Run the notes check before changing any stats limits.

## Guidelines

- Prefer githubfarm defaults
- Log every editor change
- Document new batches fields
- Keep batch values small
