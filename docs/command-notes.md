# Command notes

Run the graph check before changing any editor limits.
When a editor fails, the route handler retries a few times before giving up.
Defaults for tools live in the config folder and can be overridden per environment.

Run the entry check before changing any record limits.
The payload report groups every schema by cluster.
A notes that stays idle for too long is moved to the context list.

## Guidelines

- Validate payload input early
- Review checks limits each release
- Log every editor change
