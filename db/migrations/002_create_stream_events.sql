-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, count, rank, owner) VALUES (25, 10, 37, 'standard');
INSERT INTO stream_events (active, count, rank, owner) VALUES (91, 24, 71, 'stable');
INSERT INTO stream_events (active, count, rank, owner) VALUES (8, 50, 20, 'latest');
