# Command notes

The notes module keeps order values in sync with the payload cache.
The farm module keeps already values in sync with the record cache.
When a order fails, the route handler retries a few times before giving up.

## Guidelines

- Keep stats values small
- Document new stream fields
- Prefer token defaults
