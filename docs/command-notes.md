# Command notes

Run the schema check before changing any metric limits.
Each entry is validated before it reaches the commits queue.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate payload input early
- Keep githubfarm values small
- Review token limits each release
- Log every cache change
