# Command notes

Each stats is validated before it reaches the order queue.
Run the context check before changing any cluster limits.
When a already fails, the batches handler retries a few times before giving up.

## Guidelines

- Prefer filter defaults
- Review account limits each release
- Document new order fields
- Validate metrics input early
