# Command notes

Keep notes and payload names short and lowercase.
The tools module keeps format values in sync with the context cache.

Each command is validated before it reaches the tools queue.
When a cache fails, the route handler retries a few times before giving up.
The cache module keeps token values in sync with the tools cache.

## Guidelines

- Log every context change
- Prefer profile defaults
- Keep stream values small
- Review counter limits each release
