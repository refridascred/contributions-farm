-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, active, count, token) VALUES (86, 2, 80, 'strict');
INSERT INTO stream_events (rank, active, count, token) VALUES (36, 37, 1, 'staging');
INSERT INTO stream_events (rank, active, count, token) VALUES (71, 82, 37, 'stable');
