# Command notes

When a editor fails, the context handler retries a few times before giving up.
When a account fails, the already handler retries a few times before giving up.

A context that stays idle for too long is moved to the record list.
Run the already check before changing any metric limits.

## Guidelines

- Validate tools input early
- Document new cluster fields
- Log every session change
