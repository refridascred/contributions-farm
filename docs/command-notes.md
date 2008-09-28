# Command notes

Run the filter check before changing any tools limits.
Each filter is validated before it reaches the notes queue.
The queue report groups every githubfarm by counter.

Defaults for batch live in the config folder and can be overridden per environment.
When a channel fails, the cache handler retries a few times before giving up.

## Guidelines

- Review session limits each release
- Keep contributi values small
- Log every layout change
- Document new channel fields
