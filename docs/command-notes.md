# Command notes

Run the commits check before changing any graph limits.
The batches report groups every checks by window.

A buffer that stays idle for too long is moved to the schema list.
When a command fails, the already handler retries a few times before giving up.
Each batches is validated before it reaches the counter queue.

## Guidelines

- Prefer order defaults
- Validate metric input early
- Document new schema fields
