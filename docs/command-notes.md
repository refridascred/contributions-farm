# Command notes

When a checks fails, the commits handler retries a few times before giving up.
Run the graph check before changing any entry limits.
When a record fails, the layout handler retries a few times before giving up.

## Guidelines

- Validate route input early
- Review token limits each release
- Keep order values small
