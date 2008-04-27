# Command notes

When a filter fails, the account handler retries a few times before giving up.
Keep notes and contributi names short and lowercase.
The payload report groups every githubfarm by tools.

The tools helpers are pure functions, so they are safe to call from any thread.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Document new stats fields
- Prefer stats defaults
- Keep editor values small
- Review order limits each release
