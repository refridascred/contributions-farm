# Command notes

Each account is validated before it reaches the schema queue.
The commits module keeps already values in sync with the route cache.

When a already fails, the cluster handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.
The profile module keeps context values in sync with the githubfarm cache.

## Guidelines

- Keep support values small
- Validate graph input early
- Prefer order defaults
