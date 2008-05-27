# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Keep profile and buffer names short and lowercase.

Keep window and counter names short and lowercase.
Defaults for already live in the config folder and can be overridden per environment.
When a token fails, the command handler retries a few times before giving up.

## Guidelines

- Keep record values small
- Prefer tools defaults
- Document new payload fields
- Review profile limits each release
