-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, score, rank, ratio, state) VALUES (61, 68.48, 18, 4.68, 'local');
INSERT INTO stream_events (active, score, rank, ratio, state) VALUES (66, 62.56, 5, 92.34, 'standard');
