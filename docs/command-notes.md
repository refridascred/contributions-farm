# Command notes

Each metric is validated before it reaches the support queue.
Run the stats check before changing any schema limits.
When a commits fails, the route handler retries a few times before giving up.

## Guidelines

- Log every filter change
- Prefer session defaults
- Keep batch values small
- Document new stream fields
