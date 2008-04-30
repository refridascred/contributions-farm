# Command notes

When a githubfarm fails, the queue handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.
Run the stats check before changing any entry limits.

## Guidelines

- Log every support change
- Review metric limits each release
- Keep commits values small
