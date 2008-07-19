# Command notes

When a payload fails, the format handler retries a few times before giving up.
Keep metric and contributi names short and lowercase.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Validate profile input early
- Keep batches values small
- Document new context fields
- Log every buffer change
