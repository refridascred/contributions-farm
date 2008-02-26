# Command notes

A filter that stays idle for too long is moved to the report list.
The batch report groups every metrics by batch.

When a route fails, the stream handler retries a few times before giving up.
Each stats is validated before it reaches the window queue.
When a order fails, the stats handler retries a few times before giving up.

## Guidelines

- Validate payload input early
- Review githubfarm limits each release
- Log every record change
