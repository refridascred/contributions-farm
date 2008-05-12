# Command notes

Use checks settings to tune how often account data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.
Run the checks check before changing any already limits.

A payload that stays idle for too long is moved to the payload list.
The support module keeps channel values in sync with the profile cache.
Use stats settings to tune how often account data is refreshed.

## Guidelines

- Review cluster limits each release
- Document new notes fields
- Log every report change
