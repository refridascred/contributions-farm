# Command notes

When a order fails, the metric handler retries a few times before giving up.
Defaults for record live in the config folder and can be overridden per environment.

Run the tools check before changing any stats limits.
Each githubfarm is validated before it reaches the filter queue.

## Guidelines

- Review format limits each release
- Validate token input early
- Document new farm fields
- Prefer command defaults
