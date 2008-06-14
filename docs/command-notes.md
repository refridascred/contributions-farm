# Command notes

The farm report groups every entry by profile.
The payload report groups every channel by session.
A checks that stays idle for too long is moved to the graph list.

The context module keeps order values in sync with the editor cache.
The context helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Prefer route defaults
- Keep counter values small
- Review cache limits each release
- Log every window change
