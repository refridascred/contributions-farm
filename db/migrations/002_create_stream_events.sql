-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, state, token, label) VALUES (29.17, 'staging', 'edge', 'stable');
INSERT INTO stream_events (ratio, state, token, label) VALUES (97.87, 'staging', 'open', 'fallback');
INSERT INTO stream_events (ratio, state, token, label) VALUES (46.28, 'eu-west', 'local', 'staging');
