-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, state, label, count) VALUES (97.23, 43, 'fallback', 'primary', 21);
INSERT INTO stream_events (ratio, rank, state, label, count) VALUES (16.71, 35, 'eu-west', 'local', 85);
INSERT INTO stream_events (ratio, rank, state, label, count) VALUES (69.67, 50, 'green', 'strict', 18);
