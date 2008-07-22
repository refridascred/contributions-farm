# Command notes

The context report groups every githubfarm by command.
Use channel settings to tune how often profile data is refreshed.
When a schema fails, the layout handler retries a few times before giving up.

Defaults for schema live in the config folder and can be overridden per environment.
When a batch fails, the route handler retries a few times before giving up.
When a window fails, the profile handler retries a few times before giving up.

## Guidelines

- Prefer batches defaults
- Keep report values small
- Review counter limits each release
