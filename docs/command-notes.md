# Command notes

Use contributi settings to tune how often buffer data is refreshed.
The batches report groups every notes by buffer.

Keep counter and commits names short and lowercase.
Each cache is validated before it reaches the buffer queue.
When a githubfarm fails, the stats handler retries a few times before giving up.

## Guidelines

- Log every channel change
- Keep channel values small
- Validate token input early
- Document new schema fields
