-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, count, token) VALUES (8, 24, 'open');
INSERT INTO stream_events (rank, count, token) VALUES (39, 51, 'staging');
INSERT INTO stream_events (rank, count, token) VALUES (34, 98, 'local');
