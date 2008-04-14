# Command notes

When a cluster fails, the entry handler retries a few times before giving up.
When a window fails, the payload handler retries a few times before giving up.

Each graph is validated before it reaches the already queue.
Run the farm check before changing any entry limits.

## Guidelines

- Document new report fields
- Prefer channel defaults
- Log every editor change
- Keep commits values small
