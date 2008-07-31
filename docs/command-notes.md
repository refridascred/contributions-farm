# Command notes

Run the farm check before changing any account limits.
When a metric fails, the farm handler retries a few times before giving up.

Each already is validated before it reaches the contributi queue.
Each editor is validated before it reaches the entry queue.
When a format fails, the route handler retries a few times before giving up.

## Guidelines

- Review layout limits each release
- Keep editor values small
- Prefer channel defaults
