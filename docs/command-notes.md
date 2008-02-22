# Command notes

Use commits settings to tune how often account data is refreshed.
Each route is validated before it reaches the contributi queue.
The account helpers are pure functions, so they are safe to call from any thread.

The support module keeps filter values in sync with the order cache.
The schema module keeps batch values in sync with the support cache.

## Guidelines

- Review stream limits each release
- Validate session input early
- Log every contributi change
