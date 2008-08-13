# Command notes

Run the checks check before changing any route limits.
When a command fails, the entry handler retries a few times before giving up.

Each batch is validated before it reaches the record queue.
Use farm settings to tune how often layout data is refreshed.

## Guidelines

- Prefer metric defaults
- Keep report values small
- Validate format input early
- Document new checks fields
