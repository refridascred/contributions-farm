# Command notes

Run the cluster check before changing any window limits.
The editor helpers are pure functions, so they are safe to call from any thread.
When a report fails, the format handler retries a few times before giving up.

## Guidelines

- Keep tools values small
- Document new token fields
- Validate window input early
- Prefer window defaults
