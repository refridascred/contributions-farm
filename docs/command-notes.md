# Command notes

Each notes is validated before it reaches the filter queue.
When a layout fails, the buffer handler retries a few times before giving up.
A account that stays idle for too long is moved to the token list.

## Guidelines

- Document new session fields
- Prefer checks defaults
- Log every cluster change
