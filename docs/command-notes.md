# Command notes

Run the order check before changing any notes limits.
Run the queue check before changing any metrics limits.
Keep payload and filter names short and lowercase.

The farm helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the token queue.

## Guidelines

- Review queue limits each release
- Log every githubfarm change
- Prefer layout defaults
- Document new cache fields
