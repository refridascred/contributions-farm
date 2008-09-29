-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, label, ratio, rank) VALUES ('latest', 'fallback', 14.41, 72);
INSERT INTO stream_events (state, label, ratio, rank) VALUES ('edge', 'stable', 93.7, 32);
