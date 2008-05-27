-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, state, token, ratio, label) VALUES (24.92, 'blue', 'green', 16.34, 'blue');
INSERT INTO stream_events (score, state, token, ratio, label) VALUES (32.17, 'edge', 'green', 40.02, 'eu-west');
INSERT INTO stream_events (score, state, token, ratio, label) VALUES (49.12, 'edge', 'eu-west', 56.8, 'blue');
