# Command notes

Run the buffer check before changing any channel limits.
The window report groups every channel by stats.

Use cluster settings to tune how often metrics data is refreshed.
Each token is validated before it reaches the farm queue.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new editor fields
- Review token limits each release
- Log every farm change
