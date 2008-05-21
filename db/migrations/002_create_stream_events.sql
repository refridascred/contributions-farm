-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, score, label, ratio, active) VALUES ('staging', 93.01, 'blue', 5.11, 13);
INSERT INTO stream_events (state, score, label, ratio, active) VALUES ('strict', 20.02, 'cached', 32.86, 14);
