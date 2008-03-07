# Command notes

Keep filter and editor names short and lowercase.
Defaults for queue live in the config folder and can be overridden per environment.
Defaults for layout live in the config folder and can be overridden per environment.

The already module keeps cache values in sync with the payload cache.
Keep metric and checks names short and lowercase.
When a entry fails, the session handler retries a few times before giving up.

## Guidelines

- Validate payload input early
- Prefer report defaults
- Document new contributi fields
