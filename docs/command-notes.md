# Command notes

Keep record and contributi names short and lowercase.
When a cache fails, the tools handler retries a few times before giving up.
Each batch is validated before it reaches the command queue.

The token helpers are pure functions, so they are safe to call from any thread.
Use commits settings to tune how often queue data is refreshed.

## Guidelines

- Log every command change
- Prefer farm defaults
- Review order limits each release
