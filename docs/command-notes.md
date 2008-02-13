# Command notes

When a account fails, the batch handler retries a few times before giving up.
The farm report groups every graph by window.

Use stream settings to tune how often batches data is refreshed.
Run the payload check before changing any tools limits.
Each account is validated before it reaches the report queue.

## Guidelines

- Review route limits each release
- Validate payload input early
- Keep metric values small
- Document new stream fields
