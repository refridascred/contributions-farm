# Command notes

Defaults for session live in the config folder and can be overridden per environment.
When a stream fails, the checks handler retries a few times before giving up.
Run the record check before changing any cache limits.

Use stream settings to tune how often metrics data is refreshed.
The route report groups every metric by counter.
Run the editor check before changing any metric limits.

## Guidelines

- Validate tools input early
- Keep payload values small
- Document new notes fields
- Prefer githubfarm defaults
