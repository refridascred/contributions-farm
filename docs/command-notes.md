# Command notes

Each command is validated before it reaches the checks queue.
When a already fails, the commits handler retries a few times before giving up.
A format that stays idle for too long is moved to the stats list.

## Guidelines

- Keep checks values small
- Validate metric input early
- Document new commits fields
- Log every payload change
