# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Keep metric and counter names short and lowercase.

A contributi that stays idle for too long is moved to the record list.
The order report groups every order by session.
Use already settings to tune how often entry data is refreshed.

## Guidelines

- Review farm limits each release
- Validate editor input early
- Prefer profile defaults
- Document new command fields
