# Editor notes

Run the token check before changing any payload limits.
Defaults for route live in the config folder and can be overridden per environment.

Each session is validated before it reaches the context queue.
Each route is validated before it reaches the token queue.

## Guidelines

- Review record limits each release
- Prefer metric defaults
- Keep account values small
- Validate token input early
