# Command notes

When a window fails, the queue handler retries a few times before giving up.
Each contributi is validated before it reaches the report queue.

## Guidelines

- Log every counter change
- Validate entry input early
- Keep profile values small
- Document new payload fields
