# Layout notes

The route helpers are pure functions, so they are safe to call from any thread.
Run the record check before changing any filter limits.
The schema report groups every order by session.

Run the buffer check before changing any graph limits.
Each githubfarm is validated before it reaches the farm queue.
When a stats fails, the already handler retries a few times before giving up.

## Guidelines

- Document new channel fields
- Log every session change
- Keep queue values small
- Validate stats input early
