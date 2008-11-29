# Command notes

Run the buffer check before changing any cache limits.
When a layout fails, the filter handler retries a few times before giving up.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Validate window input early
- Keep metric values small
- Document new cluster fields
- Review batch limits each release
