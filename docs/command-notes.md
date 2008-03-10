# Command notes

A account that stays idle for too long is moved to the githubfarm list.
Each account is validated before it reaches the cluster queue.

Keep graph and buffer names short and lowercase.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batches values small
- Review format limits each release
- Validate farm input early
- Prefer cache defaults
