# Command notes

Defaults for record live in the config folder and can be overridden per environment.
Each profile is validated before it reaches the channel queue.
Keep graph and githubfarm names short and lowercase.

The route helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the format handler retries a few times before giving up.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Review channel limits each release
- Document new route fields
- Validate cluster input early
