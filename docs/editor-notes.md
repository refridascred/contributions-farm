# Editor notes

Keep checks and checks names short and lowercase.
Keep contributi and command names short and lowercase.
Run the githubfarm check before changing any queue limits.

When a cache fails, the stats handler retries a few times before giving up.
The metrics helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Review account limits each release
- Prefer order defaults
- Validate farm input early
