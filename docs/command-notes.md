# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The filter module keeps queue values in sync with the editor cache.

When a commits fails, the entry handler retries a few times before giving up.
Defaults for metrics live in the config folder and can be overridden per environment.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Review token limits each release
- Log every schema change
- Prefer metric defaults
- Document new window fields
