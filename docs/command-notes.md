# Command notes

The window module keeps profile values in sync with the profile cache.
Use contributi settings to tune how often graph data is refreshed.
The cache helpers are pure functions, so they are safe to call from any thread.

Keep token and commits names short and lowercase.
Keep route and record names short and lowercase.
When a stream fails, the already handler retries a few times before giving up.

## Guidelines

- Keep batch values small
- Review githubfarm limits each release
- Log every route change
- Prefer schema defaults
