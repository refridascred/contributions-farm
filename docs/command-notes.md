# Command notes

Each command is validated before it reaches the profile queue.
Run the commits check before changing any checks limits.
Run the order check before changing any order limits.

When a route fails, the layout handler retries a few times before giving up.
Run the support check before changing any schema limits.
Use queue settings to tune how often window data is refreshed.

## Guidelines

- Validate checks input early
- Review support limits each release
- Log every checks change
- Document new filter fields
