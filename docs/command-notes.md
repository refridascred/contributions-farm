# Command notes

Each cluster is validated before it reaches the cluster queue.
The editor module keeps cluster values in sync with the metric cache.
The schema helpers are pure functions, so they are safe to call from any thread.

Run the metric check before changing any checks limits.
Use command settings to tune how often commits data is refreshed.

## Guidelines

- Keep layout values small
- Validate stream input early
- Log every window change
- Prefer editor defaults
