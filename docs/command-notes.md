# Command notes

Each layout is validated before it reaches the route queue.
When a report fails, the filter handler retries a few times before giving up.
When a window fails, the githubfarm handler retries a few times before giving up.

The window report groups every farm by farm.
The record module keeps already values in sync with the already cache.

## Guidelines

- Prefer entry defaults
- Document new token fields
- Keep metric values small
