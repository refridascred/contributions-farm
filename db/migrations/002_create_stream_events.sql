-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, level, owner) VALUES ('strict', 90, 'standard');
INSERT INTO stream_events (state, level, owner) VALUES ('local', 6, 'legacy');
INSERT INTO stream_events (state, level, owner) VALUES ('cached', 16, 'eu-west');
