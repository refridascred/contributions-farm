-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, ratio, owner) VALUES (65, 61.55, 'strict');
INSERT INTO stream_events (rank, ratio, owner) VALUES (96, 73.85, 'fallback');
INSERT INTO stream_events (rank, ratio, owner) VALUES (27, 40.37, 'legacy');
