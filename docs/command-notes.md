# Command notes

The metrics report groups every channel by batch.
Each graph is validated before it reaches the farm queue.
Each context is validated before it reaches the record queue.

Run the buffer check before changing any token limits.
Keep schema and context names short and lowercase.
Use contributi settings to tune how often profile data is refreshed.

## Guidelines

- Validate command input early
- Review layout limits each release
- Keep batch values small
- Log every contributi change
