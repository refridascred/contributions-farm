# Command notes

When a command fails, the counter handler retries a few times before giving up.
When a buffer fails, the layout handler retries a few times before giving up.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review token limits each release
- Keep batch values small
- Log every channel change
- Document new stream fields
