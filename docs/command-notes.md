# Command notes

A session that stays idle for too long is moved to the cluster list.
Defaults for session live in the config folder and can be overridden per environment.
Run the tools check before changing any report limits.

The stats report groups every queue by farm.
Run the buffer check before changing any batches limits.

## Guidelines

- Log every buffer change
- Keep batch values small
- Prefer batch defaults
