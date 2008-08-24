# Command notes

Run the record check before changing any route limits.
Use schema settings to tune how often context data is refreshed.

The window helpers are pure functions, so they are safe to call from any thread.
The order module keeps metric values in sync with the githubfarm cache.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Review filter limits each release
- Validate contributi input early
- Keep entry values small
- Log every buffer change
