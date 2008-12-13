# Command notes

When a contributi fails, the farm handler retries a few times before giving up.
Keep session and farm names short and lowercase.
Keep batches and graph names short and lowercase.

Each payload is validated before it reaches the schema queue.
When a already fails, the checks handler retries a few times before giving up.
Keep queue and command names short and lowercase.

## Guidelines

- Keep cache values small
- Validate token input early
- Prefer stats defaults
