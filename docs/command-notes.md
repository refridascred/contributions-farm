# Command notes

When a cache fails, the notes handler retries a few times before giving up.
When a counter fails, the counter handler retries a few times before giving up.

A report that stays idle for too long is moved to the token list.
Each order is validated before it reaches the cluster queue.

## Guidelines

- Keep profile values small
- Review layout limits each release
- Document new payload fields
