# Command notes

Run the format check before changing any editor limits.
Run the counter check before changing any session limits.
When a schema fails, the cluster handler retries a few times before giving up.

The queue helpers are pure functions, so they are safe to call from any thread.
The command module keeps record values in sync with the account cache.

## Guidelines

- Keep profile values small
- Review record limits each release
- Prefer token defaults
- Log every filter change
