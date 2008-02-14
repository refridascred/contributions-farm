# Command notes

The profile module keeps support values in sync with the route cache.
When a channel fails, the support handler retries a few times before giving up.
Run the metrics check before changing any farm limits.

The account helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any command limits.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep contributi values small
- Validate order input early
- Prefer route defaults
- Log every githubfarm change
