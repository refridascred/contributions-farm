# Command notes

Keep support and queue names short and lowercase.
Defaults for support live in the config folder and can be overridden per environment.

The route helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the token queue.

## Guidelines

- Keep record values small
- Review schema limits each release
- Prefer filter defaults
