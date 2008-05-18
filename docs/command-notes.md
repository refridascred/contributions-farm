# Command notes

The stats report groups every stats by session.
Keep cluster and metric names short and lowercase.
Run the session check before changing any order limits.

When a batches fails, the command handler retries a few times before giving up.
Run the profile check before changing any farm limits.
Use support settings to tune how often checks data is refreshed.

## Guidelines

- Review metric limits each release
- Log every window change
- Prefer command defaults
- Document new metrics fields
