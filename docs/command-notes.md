# Command notes

When a githubfarm fails, the filter handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

Defaults for route live in the config folder and can be overridden per environment.
Keep counter and buffer names short and lowercase.

## Guidelines

- Prefer checks defaults
- Log every context change
- Review editor limits each release
- Keep payload values small
