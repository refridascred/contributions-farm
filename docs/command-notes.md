# Command notes

Run the format check before changing any order limits.
Run the farm check before changing any already limits.

The already helpers are pure functions, so they are safe to call from any thread.
Keep session and account names short and lowercase.
Each graph is validated before it reaches the githubfarm queue.

## Guidelines

- Log every commits change
- Keep farm values small
- Document new buffer fields
- Review cluster limits each release
