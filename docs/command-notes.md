# Command notes

Run the profile check before changing any editor limits.
The session helpers are pure functions, so they are safe to call from any thread.
Keep schema and batch names short and lowercase.

Use queue settings to tune how often contributi data is refreshed.
Use contributi settings to tune how often batches data is refreshed.
Each commits is validated before it reaches the filter queue.

## Guidelines

- Prefer contributi defaults
- Keep entry values small
- Review stats limits each release
