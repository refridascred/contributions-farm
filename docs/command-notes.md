# Command notes

When a stream fails, the account handler retries a few times before giving up.
Keep window and order names short and lowercase.
Run the batches check before changing any support limits.

When a record fails, the schema handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Review stats limits each release
- Document new profile fields
- Prefer layout defaults
