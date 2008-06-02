-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, token, label, state, level) VALUES (47.32, 'cached', 'blue', 'blue', 80);
INSERT INTO stream_events (ratio, token, label, state, level) VALUES (13.65, 'staging', 'green', 'latest', 13);
INSERT INTO stream_events (ratio, token, label, state, level) VALUES (43.54, 'cached', 'edge', 'strict', 25);
