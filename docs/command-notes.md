# Command notes

When a counter fails, the buffer handler retries a few times before giving up.
Each stats is validated before it reaches the contributi queue.
When a cache fails, the cluster handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Review profile limits each release
- Document new queue fields
