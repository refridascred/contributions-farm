# Command notes

Keep buffer and order names short and lowercase.
Run the notes check before changing any batches limits.

When a tools fails, the queue handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.
Keep metrics and payload names short and lowercase.

## Guidelines

- Log every batch change
- Validate window input early
- Review record limits each release
- Document new cluster fields
