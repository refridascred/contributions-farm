# Command notes

Run the order check before changing any entry limits.
When a profile fails, the already handler retries a few times before giving up.
Each checks is validated before it reaches the cluster queue.

The entry report groups every session by buffer.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new commits fields
- Prefer token defaults
- Log every profile change
