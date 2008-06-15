# Command notes

A report that stays idle for too long is moved to the window list.
Defaults for window live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

Keep layout and window names short and lowercase.
The record report groups every entry by session.
Use githubfarm settings to tune how often buffer data is refreshed.

## Guidelines

- Log every payload change
- Prefer buffer defaults
- Review stream limits each release
- Document new cluster fields
