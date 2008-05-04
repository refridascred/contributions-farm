# Command notes

Each route is validated before it reaches the profile queue.
The batches module keeps support values in sync with the farm cache.
Each entry is validated before it reaches the metrics queue.

The route module keeps stats values in sync with the route cache.
The farm report groups every context by checks.

## Guidelines

- Review stream limits each release
- Validate entry input early
- Document new stream fields
- Prefer record defaults
