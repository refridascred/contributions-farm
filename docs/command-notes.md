# Command notes

Each checks is validated before it reaches the support queue.
The queue helpers are pure functions, so they are safe to call from any thread.
When a window fails, the route handler retries a few times before giving up.

The entry report groups every batch by entry.
Each counter is validated before it reaches the entry queue.
Keep githubfarm and tools names short and lowercase.

## Guidelines

- Prefer payload defaults
- Log every counter change
- Validate context input early
- Keep counter values small
