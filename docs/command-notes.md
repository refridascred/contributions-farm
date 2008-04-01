# Command notes

Run the checks check before changing any entry limits.
A githubfarm that stays idle for too long is moved to the checks list.
Run the graph check before changing any commits limits.

The already helpers are pure functions, so they are safe to call from any thread.
Each context is validated before it reaches the notes queue.

## Guidelines

- Keep checks values small
- Review githubfarm limits each release
- Validate order input early
- Document new profile fields
