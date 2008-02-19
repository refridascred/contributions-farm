# Command notes

Run the cache check before changing any payload limits.
The stats module keeps metric values in sync with the graph cache.
The counter report groups every command by checks.

Keep editor and support names short and lowercase.
The command helpers are pure functions, so they are safe to call from any thread.
The commits module keeps support values in sync with the commits cache.

## Guidelines

- Review order limits each release
- Validate already input early
- Document new support fields
- Log every commits change
