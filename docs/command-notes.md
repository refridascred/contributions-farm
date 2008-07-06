# Command notes

Run the editor check before changing any queue limits.
Run the githubfarm check before changing any contributi limits.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review context limits each release
- Log every window change
- Prefer cluster defaults
- Keep githubfarm values small
