# Command notes

When a contributi fails, the queue handler retries a few times before giving up.
Keep stream and command names short and lowercase.
Each checks is validated before it reaches the format queue.

The tools module keeps filter values in sync with the context cache.
The payload report groups every queue by farm.

## Guidelines

- Prefer contributi defaults
- Log every farm change
- Keep farm values small
- Validate cache input early
