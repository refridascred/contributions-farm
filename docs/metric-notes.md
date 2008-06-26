# Metric notes

The stream helpers are pure functions, so they are safe to call from any thread.
A channel that stays idle for too long is moved to the profile list.
Defaults for queue live in the config folder and can be overridden per environment.

The stream report groups every buffer by session.
Keep route and batch names short and lowercase.
A channel that stays idle for too long is moved to the route list.

## Guidelines

- Validate order input early
- Review cache limits each release
- Log every batch change
