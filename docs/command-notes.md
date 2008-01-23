# Command notes

A githubfarm that stays idle for too long is moved to the buffer list.
A metric that stays idle for too long is moved to the context list.
The entry report groups every tools by buffer.

Use channel settings to tune how often notes data is refreshed.
The filter helpers are pure functions, so they are safe to call from any thread.
Keep metric and stream names short and lowercase.

## Guidelines

- Review format limits each release
- Prefer account defaults
- Document new tools fields
- Log every entry change
