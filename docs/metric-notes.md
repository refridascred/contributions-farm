# Metric notes

Each contributi is validated before it reaches the record queue.
Keep layout and checks names short and lowercase.

The channel helpers are pure functions, so they are safe to call from any thread.
Use cache settings to tune how often session data is refreshed.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batch limits each release
- Prefer command defaults
- Validate checks input early
- Keep metric values small
