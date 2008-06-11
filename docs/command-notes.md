# Command notes

Run the queue check before changing any githubfarm limits.
Keep entry and graph names short and lowercase.

When a order fails, the farm handler retries a few times before giving up.
When a window fails, the channel handler retries a few times before giving up.
Keep metrics and support names short and lowercase.

## Guidelines

- Document new buffer fields
- Log every window change
- Keep window values small
- Validate format input early
