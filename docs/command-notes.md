# Command notes

When a contributi fails, the editor handler retries a few times before giving up.
When a contributi fails, the record handler retries a few times before giving up.

The window helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.
Run the order check before changing any metric limits.

## Guidelines

- Document new profile fields
- Review report limits each release
- Log every buffer change
- Validate batches input early
