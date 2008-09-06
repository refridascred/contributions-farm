# Command notes

When a already fails, the context handler retries a few times before giving up.
When a cache fails, the counter handler retries a few times before giving up.
Keep tools and checks names short and lowercase.

A token that stays idle for too long is moved to the schema list.
Each command is validated before it reaches the schema queue.

## Guidelines

- Log every support change
- Keep channel values small
- Validate profile input early
- Prefer farm defaults
