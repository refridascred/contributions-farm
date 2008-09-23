# Editor notes

The order helpers are pure functions, so they are safe to call from any thread.
Defaults for context live in the config folder and can be overridden per environment.
The batches report groups every order by format.

The counter report groups every session by report.
The farm report groups every support by entry.
A payload that stays idle for too long is moved to the filter list.

## Guidelines

- Keep support values small
- Document new stream fields
- Validate metric input early
