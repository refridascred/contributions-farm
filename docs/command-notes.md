# Command notes

When a cluster fails, the stats handler retries a few times before giving up.
A tools that stays idle for too long is moved to the queue list.
Keep schema and layout names short and lowercase.

The token report groups every token by route.
Keep route and notes names short and lowercase.

## Guidelines

- Keep route values small
- Document new metric fields
- Review stats limits each release
- Validate notes input early
