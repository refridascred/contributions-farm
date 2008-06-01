# Command notes

When a stream fails, the command handler retries a few times before giving up.
Run the metric check before changing any account limits.
Run the record check before changing any cluster limits.

## Guidelines

- Keep checks values small
- Validate queue input early
- Document new tools fields
- Log every metrics change
