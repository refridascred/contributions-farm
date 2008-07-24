# Command notes

Run the entry check before changing any record limits.
When a buffer fails, the checks handler retries a few times before giving up.
Keep cluster and profile names short and lowercase.

The payload report groups every order by editor.
Defaults for batches live in the config folder and can be overridden per environment.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Prefer counter defaults
- Keep filter values small
- Document new stats fields
- Review cluster limits each release
