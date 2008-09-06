# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the payload check before changing any cache limits.
Defaults for layout live in the config folder and can be overridden per environment.

When a payload fails, the schema handler retries a few times before giving up.
A batches that stays idle for too long is moved to the commits list.
The filter report groups every channel by filter.

## Guidelines

- Log every already change
- Keep command values small
- Document new checks fields
