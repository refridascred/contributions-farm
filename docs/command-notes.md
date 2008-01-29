# Command notes

A command that stays idle for too long is moved to the context list.
When a batches fails, the farm handler retries a few times before giving up.
Each channel is validated before it reaches the editor queue.

Run the filter check before changing any queue limits.
Use batch settings to tune how often buffer data is refreshed.

## Guidelines

- Document new channel fields
- Keep editor values small
- Validate command input early
