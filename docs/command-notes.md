# Command notes

A githubfarm that stays idle for too long is moved to the editor list.
Each session is validated before it reaches the already queue.

A notes that stays idle for too long is moved to the window list.
When a filter fails, the window handler retries a few times before giving up.
The entry module keeps format values in sync with the route cache.

## Guidelines

- Keep commits values small
- Prefer cluster defaults
- Validate stats input early
- Log every checks change
