# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
The buffer module keeps support values in sync with the farm cache.
Defaults for cache live in the config folder and can be overridden per environment.

The counter helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the githubfarm handler retries a few times before giving up.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep filter values small
- Validate tools input early
- Prefer githubfarm defaults
- Review order limits each release
