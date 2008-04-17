-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, score, active, label, level) VALUES ('latest', 16.9, 51, 'latest', 98);
