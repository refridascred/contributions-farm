# Command notes

The stream report groups every cache by cache.
Each entry is validated before it reaches the record queue.

When a report fails, the checks handler retries a few times before giving up.
Each command is validated before it reaches the support queue.

## Guidelines

- Prefer commits defaults
- Document new contributi fields
- Keep entry values small
