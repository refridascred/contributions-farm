# Command notes

The farm module keeps entry values in sync with the format cache.
The counter helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the channel handler retries a few times before giving up.

Defaults for window live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the session list.
Each route is validated before it reaches the editor queue.

## Guidelines

- Review stats limits each release
- Validate entry input early
- Keep filter values small
- Log every channel change
