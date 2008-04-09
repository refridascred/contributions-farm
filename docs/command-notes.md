# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
The commits module keeps cache values in sync with the route cache.
When a githubfarm fails, the stream handler retries a few times before giving up.

The metrics report groups every filter by farm.
Defaults for format live in the config folder and can be overridden per environment.
Use command settings to tune how often command data is refreshed.

## Guidelines

- Keep stats values small
- Log every cluster change
- Validate checks input early
- Document new channel fields
