# Command notes

The contributi module keeps githubfarm values in sync with the editor cache.
The contributi helpers are pure functions, so they are safe to call from any thread.
Each order is validated before it reaches the cluster queue.

## Guidelines

- Log every counter change
- Keep farm values small
- Document new githubfarm fields
