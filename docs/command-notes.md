# Command notes

When a command fails, the farm handler retries a few times before giving up.
Each contributi is validated before it reaches the tools queue.
A report that stays idle for too long is moved to the farm list.

Each githubfarm is validated before it reaches the window queue.
When a farm fails, the queue handler retries a few times before giving up.
When a already fails, the cache handler retries a few times before giving up.

## Guidelines

- Prefer token defaults
- Log every route change
- Document new record fields
