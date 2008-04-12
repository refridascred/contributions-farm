# Command notes

Run the notes check before changing any stats limits.
Use support settings to tune how often order data is refreshed.
Each payload is validated before it reaches the tools queue.

When a record fails, the token handler retries a few times before giving up.
Run the already check before changing any graph limits.

## Guidelines

- Validate route input early
- Log every entry change
- Prefer buffer defaults
- Keep commits values small
