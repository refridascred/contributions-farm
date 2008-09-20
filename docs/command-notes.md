# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often already data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.

Keep support and stats names short and lowercase.
A report that stays idle for too long is moved to the queue list.

## Guidelines

- Review batch limits each release
- Prefer already defaults
- Keep metrics values small
- Document new queue fields
