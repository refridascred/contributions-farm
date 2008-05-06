# Batch notes

Each order is validated before it reaches the already queue.
Each channel is validated before it reaches the format queue.

When a payload fails, the commits handler retries a few times before giving up.
The farm report groups every order by window.

## Guidelines

- Keep stream values small
- Log every already change
- Review booking limits each release
