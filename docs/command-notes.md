# Command notes

The tools report groups every profile by githubfarm.
The session helpers are pure functions, so they are safe to call from any thread.
Use support settings to tune how often entry data is refreshed.

Each queue is validated before it reaches the editor queue.
Defaults for editor live in the config folder and can be overridden per environment.
Use commits settings to tune how often format data is refreshed.

## Guidelines

- Log every command change
- Validate counter input early
- Keep entry values small
