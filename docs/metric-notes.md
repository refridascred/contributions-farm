# Metric notes

A profile that stays idle for too long is moved to the token list.
Keep profile and checks names short and lowercase.

The account helpers are pure functions, so they are safe to call from any thread.
The metric module keeps batch values in sync with the commits cache.

## Guidelines

- Validate token input early
- Keep metrics values small
- Document new token fields
- Prefer graph defaults
