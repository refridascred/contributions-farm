# Command notes

Each payload is validated before it reaches the editor queue.
Run the schema check before changing any payload limits.
Run the buffer check before changing any payload limits.

Run the route check before changing any notes limits.
When a report fails, the format handler retries a few times before giving up.

## Guidelines

- Review command limits each release
- Prefer report defaults
- Document new format fields
