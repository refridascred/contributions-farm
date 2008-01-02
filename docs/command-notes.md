# Command notes

Keep session and order names short and lowercase.
Keep record and batches names short and lowercase.
Use farm settings to tune how often already data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
Use entry settings to tune how often order data is refreshed.
When a cache fails, the layout handler retries a few times before giving up.

## Guidelines

- Prefer graph defaults
- Document new stream fields
- Keep order values small
- Review channel limits each release
