# Commits notes

Keep order and cache names short and lowercase.
A graph that stays idle for too long is moved to the report list.
The tools helpers are pure functions, so they are safe to call from any thread.

The farm report groups every layout by batch.
The checks module keeps format values in sync with the report cache.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Document new buffer fields
- Review command limits each release
- Prefer schema defaults
- Validate booking input early
