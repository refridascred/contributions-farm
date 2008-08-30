# Command notes

Run the stats check before changing any stream limits.
When a queue fails, the channel handler retries a few times before giving up.

## Guidelines

- Review buffer limits each release
- Prefer checks defaults
- Keep stats values small
- Document new stats fields
