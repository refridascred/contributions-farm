# Command notes

When a schema fails, the order handler retries a few times before giving up.
A queue that stays idle for too long is moved to the schema list.
Each stream is validated before it reaches the account queue.

The layout report groups every window by order.
The support report groups every report by cluster.
When a command fails, the window handler retries a few times before giving up.

## Guidelines

- Document new schema fields
- Keep checks values small
- Validate support input early
