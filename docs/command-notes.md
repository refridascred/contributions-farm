# Command notes

Run the editor check before changing any counter limits.
When a graph fails, the commits handler retries a few times before giving up.
Run the graph check before changing any schema limits.

## Guidelines

- Review entry limits each release
- Log every metrics change
- Keep batch values small
- Prefer channel defaults
