-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, rank, label, score) VALUES ('primary', 20, 'fallback', 82.68);
INSERT INTO stream_events (state, rank, label, score) VALUES ('blue', 76, 'green', 32.86);
