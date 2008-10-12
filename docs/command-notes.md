# Command notes

Run the queue check before changing any tools limits.
When a session fails, the farm handler retries a few times before giving up.
Each batch is validated before it reaches the profile queue.

## Guidelines

- Prefer context defaults
- Review token limits each release
- Document new counter fields
