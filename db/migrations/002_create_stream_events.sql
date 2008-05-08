-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, level, label) VALUES ('local', 40, 'local');
INSERT INTO stream_events (state, level, label) VALUES ('fallback', 77, 'standard');
