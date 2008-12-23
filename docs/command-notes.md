# Command notes

Each format is validated before it reaches the graph queue.
The metrics report groups every token by profile.
A stream that stays idle for too long is moved to the token list.

A payload that stays idle for too long is moved to the session list.
Use record settings to tune how often stream data is refreshed.

## Guidelines

- Prefer metric defaults
- Review channel limits each release
- Log every report change
