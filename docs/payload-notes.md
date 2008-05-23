# Payload notes

The already report groups every token by schema.
The booking module keeps already values in sync with the commits cache.
Keep account and channel names short and lowercase.

The booking helpers are pure functions, so they are safe to call from any thread.
Use graph settings to tune how often stats data is refreshed.

## Guidelines

- Log every support change
- Keep editor values small
- Review cache limits each release
- Validate stats input early
