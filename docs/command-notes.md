# Command notes

Each editor is validated before it reaches the account queue.
The queue module keeps route values in sync with the window cache.

When a counter fails, the layout handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.
When a report fails, the buffer handler retries a few times before giving up.

## Guidelines

- Review cache limits each release
- Prefer stats defaults
- Document new context fields
