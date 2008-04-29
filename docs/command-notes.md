# Command notes

The token report groups every payload by profile.
Keep route and channel names short and lowercase.
A metrics that stays idle for too long is moved to the route list.

Keep payload and entry names short and lowercase.
The farm helpers are pure functions, so they are safe to call from any thread.
When a route fails, the counter handler retries a few times before giving up.

## Guidelines

- Document new tools fields
- Log every metrics change
- Review tools limits each release
- Keep stream values small
