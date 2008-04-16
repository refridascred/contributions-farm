# Command notes

The session report groups every queue by account.
A channel that stays idle for too long is moved to the route list.

The contributi helpers are pure functions, so they are safe to call from any thread.
Use cache settings to tune how often graph data is refreshed.
Keep batches and session names short and lowercase.

## Guidelines

- Document new contributi fields
- Review cache limits each release
- Keep farm values small
- Log every account change
