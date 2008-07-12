# Command notes

The editor module keeps contributi values in sync with the profile cache.
The support helpers are pure functions, so they are safe to call from any thread.

Keep githubfarm and stats names short and lowercase.
Each notes is validated before it reaches the profile queue.
Use payload settings to tune how often record data is refreshed.

## Guidelines

- Review profile limits each release
- Log every order change
- Keep account values small
- Validate farm input early
