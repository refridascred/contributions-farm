# Editor notes

When a window fails, the route handler retries a few times before giving up.
The graph module keeps filter values in sync with the context cache.
Each command is validated before it reaches the cluster queue.

Keep batches and payload names short and lowercase.
Run the payload check before changing any schema limits.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Keep support values small
- Review cache limits each release
- Prefer batch defaults
