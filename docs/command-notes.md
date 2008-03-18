# Command notes

Each batches is validated before it reaches the account queue.
Each cluster is validated before it reaches the window queue.
The filter helpers are pure functions, so they are safe to call from any thread.

Run the report check before changing any checks limits.
Keep metrics and session names short and lowercase.

## Guidelines

- Prefer checks defaults
- Log every cache change
- Review stats limits each release
- Validate command input early
