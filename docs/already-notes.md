# Already notes

The already module keeps session values in sync with the token cache.
Defaults for buffer live in the config folder and can be overridden per environment.
Each record is validated before it reaches the session queue.

## Guidelines

- Keep token values small
- Review metric limits each release
- Prefer schema defaults
- Document new commits fields
