# Command notes

When a batches fails, the buffer handler retries a few times before giving up.
Each notes is validated before it reaches the window queue.
The batches module keeps filter values in sync with the cluster cache.

## Guidelines

- Prefer metrics defaults
- Document new metric fields
- Review format limits each release
