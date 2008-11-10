# Command notes

When a command fails, the buffer handler retries a few times before giving up.
Each graph is validated before it reaches the payload queue.

Use metrics settings to tune how often window data is refreshed.
A window that stays idle for too long is moved to the payload list.

## Guidelines

- Validate token input early
- Keep filter values small
- Document new support fields
- Log every counter change
