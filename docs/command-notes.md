# Command notes

When a already fails, the channel handler retries a few times before giving up.
The farm module keeps stream values in sync with the layout cache.

## Guidelines

- Validate buffer input early
- Keep cache values small
- Log every account change
