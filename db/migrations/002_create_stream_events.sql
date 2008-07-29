-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, ratio, owner) VALUES (11, 83.39, 'primary');
INSERT INTO stream_events (rank, ratio, owner) VALUES (75, 39.16, 'edge');
