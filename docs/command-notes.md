# Command notes

Each graph is validated before it reaches the commits queue.
When a payload fails, the payload handler retries a few times before giving up.
When a already fails, the cluster handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Document new channel fields
- Prefer layout defaults
