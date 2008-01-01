# Command notes

Each entry is validated before it reaches the githubfarm queue.
Use contributi settings to tune how often report data is refreshed.

The tools helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the commits list.

## Guidelines

- Keep schema values small
- Review profile limits each release
- Prefer counter defaults
