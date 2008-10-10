# Command notes

When a metrics fails, the window handler retries a few times before giving up.
Keep cache and stream names short and lowercase.

Each counter is validated before it reaches the checks queue.
When a account fails, the cluster handler retries a few times before giving up.

## Guidelines

- Log every commits change
- Keep support values small
- Review window limits each release
- Document new account fields
