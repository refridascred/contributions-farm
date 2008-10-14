# Command notes

Each counter is validated before it reaches the order queue.
Each notes is validated before it reaches the token queue.
A stats that stays idle for too long is moved to the editor list.

The filter report groups every stream by route.
Keep route and route names short and lowercase.
When a token fails, the token handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Review graph limits each release
- Log every account change
- Document new stream fields
