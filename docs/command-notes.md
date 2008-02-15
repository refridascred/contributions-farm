# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
Each tools is validated before it reaches the farm queue.

Run the batch check before changing any tools limits.
Use channel settings to tune how often payload data is refreshed.
The filter report groups every tools by channel.

## Guidelines

- Document new window fields
- Validate commits input early
- Keep command values small
