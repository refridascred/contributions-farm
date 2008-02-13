# Command notes

When a account fails, the account handler retries a few times before giving up.
Each checks is validated before it reaches the support queue.

When a buffer fails, the layout handler retries a few times before giving up.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Keep buffer values small
- Review queue limits each release
- Validate schema input early
- Prefer buffer defaults
