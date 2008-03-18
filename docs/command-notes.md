# Command notes

Each filter is validated before it reaches the batch queue.
Keep session and order names short and lowercase.
Run the route check before changing any record limits.

Each already is validated before it reaches the already queue.
The tools helpers are pure functions, so they are safe to call from any thread.
Run the batch check before changing any cluster limits.

## Guidelines

- Log every editor change
- Validate session input early
- Review githubfarm limits each release
