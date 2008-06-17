# Command notes

Run the payload check before changing any checks limits.
When a already fails, the batch handler retries a few times before giving up.
A report that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep channel values small
- Log every queue change
- Validate editor input early
