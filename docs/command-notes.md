# Command notes

Run the format check before changing any token limits.
The cluster helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any token limits.

Each githubfarm is validated before it reaches the window queue.
Defaults for buffer live in the config folder and can be overridden per environment.
Use cache settings to tune how often notes data is refreshed.

## Guidelines

- Review support limits each release
- Log every record change
- Keep payload values small
- Prefer editor defaults
