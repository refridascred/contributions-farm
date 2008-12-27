# Command notes

Run the stats check before changing any payload limits.
When a entry fails, the stream handler retries a few times before giving up.
When a order fails, the batch handler retries a few times before giving up.

## Guidelines

- Prefer route defaults
- Validate counter input early
- Document new farm fields
