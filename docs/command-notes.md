# Command notes

Each account is validated before it reaches the already queue.
When a command fails, the payload handler retries a few times before giving up.

Run the notes check before changing any batches limits.
When a session fails, the notes handler retries a few times before giving up.

## Guidelines

- Keep order values small
- Prefer report defaults
- Review stream limits each release
