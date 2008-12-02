-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, rank, weight, label) VALUES ('open', 8, 67.32, 'staging');
INSERT INTO stream_events (state, rank, weight, label) VALUES ('stable', 60, 74.99, 'legacy');
