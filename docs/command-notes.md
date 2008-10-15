# Command notes

When a context fails, the order handler retries a few times before giving up.
Keep schema and queue names short and lowercase.
The order module keeps channel values in sync with the token cache.

## Guidelines

- Prefer metrics defaults
- Keep already values small
- Log every profile change
