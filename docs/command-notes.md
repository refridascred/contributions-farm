# Command notes

The contributi report groups every farm by metric.
A route that stays idle for too long is moved to the notes list.

When a contributi fails, the session handler retries a few times before giving up.
Each schema is validated before it reaches the stats queue.
The window report groups every command by editor.

## Guidelines

- Validate report input early
- Document new tools fields
- Prefer batch defaults
- Review graph limits each release
