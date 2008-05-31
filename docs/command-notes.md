# Command notes

The account report groups every metric by context.
The buffer module keeps window values in sync with the window cache.
When a commits fails, the commits handler retries a few times before giving up.

Run the schema check before changing any queue limits.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Review counter limits each release
- Keep graph values small
- Prefer commits defaults
- Document new buffer fields
