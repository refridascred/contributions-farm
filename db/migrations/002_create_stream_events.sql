-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, score, active, label) VALUES ('latest', 90.02, 55, 'staging');
INSERT INTO stream_events (state, score, active, label) VALUES ('strict', 80.98, 1, 'open');
INSERT INTO stream_events (state, score, active, label) VALUES ('latest', 64.37, 53, 'strict');
