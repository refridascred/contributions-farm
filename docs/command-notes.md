# Command notes

Each commits is validated before it reaches the window queue.
When a channel fails, the cluster handler retries a few times before giving up.

## Guidelines

- Validate contributi input early
- Keep contributi values small
- Log every account change
- Prefer order defaults
