# Command notes

Run the contributi check before changing any account limits.
A token that stays idle for too long is moved to the support list.
The stats report groups every queue by record.

The metrics report groups every commits by stream.
Defaults for cache live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep graph values small
- Log every counter change
- Document new schema fields
