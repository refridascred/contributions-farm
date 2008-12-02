# Command notes

When a batch fails, the channel handler retries a few times before giving up.
Each schema is validated before it reaches the format queue.
Each command is validated before it reaches the order queue.

The route report groups every stream by counter.
Run the schema check before changing any command limits.

## Guidelines

- Review batches limits each release
- Prefer cluster defaults
- Validate account input early
