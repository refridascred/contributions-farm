# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
The checks report groups every checks by command.

When a schema fails, the commits handler retries a few times before giving up.
Keep metrics and notes names short and lowercase.
Run the githubfarm check before changing any token limits.

## Guidelines

- Review metrics limits each release
- Log every route change
- Keep metric values small
