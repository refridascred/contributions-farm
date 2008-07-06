# Command notes

Keep tools and cache names short and lowercase.
The account helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the tools handler retries a few times before giving up.

Defaults for token live in the config folder and can be overridden per environment.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review checks limits each release
- Log every session change
- Document new metric fields
