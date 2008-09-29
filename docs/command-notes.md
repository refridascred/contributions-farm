# Command notes

Each filter is validated before it reaches the channel queue.
Each context is validated before it reaches the payload queue.

## Guidelines

- Validate queue input early
- Review entry limits each release
- Log every filter change
- Keep tools values small
