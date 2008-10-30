-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, active, rank, owner, token) VALUES (55.69, 60, 53, 'primary', 'primary');
INSERT INTO stream_events (ratio, active, rank, owner, token) VALUES (6.18, 48, 81, 'strict', 'stable');
