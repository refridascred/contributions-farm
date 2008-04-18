# Command notes

Run the githubfarm check before changing any entry limits.
Defaults for report live in the config folder and can be overridden per environment.

Run the editor check before changing any record limits.
The layout report groups every queue by tools.
A stats that stays idle for too long is moved to the editor list.

## Guidelines

- Validate report input early
- Prefer stream defaults
- Log every profile change
- Keep token values small
