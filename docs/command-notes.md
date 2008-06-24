# Command notes

Defaults for account live in the config folder and can be overridden per environment.
Keep farm and contributi names short and lowercase.

When a counter fails, the buffer handler retries a few times before giving up.
Run the token check before changing any buffer limits.
The cluster module keeps token values in sync with the filter cache.

## Guidelines

- Validate session input early
- Document new farm fields
- Prefer token defaults
