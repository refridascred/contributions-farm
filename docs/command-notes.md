# Command notes

Each channel is validated before it reaches the tools queue.
Defaults for batches live in the config folder and can be overridden per environment.

The checks report groups every batches by layout.
Run the format check before changing any buffer limits.
Each metric is validated before it reaches the token queue.

## Guidelines

- Log every queue change
- Validate contributi input early
- Document new layout fields
- Review token limits each release
