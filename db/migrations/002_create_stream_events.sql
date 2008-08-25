-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, ratio, owner, rank) VALUES ('legacy', 0.75, 'fallback', 84);
INSERT INTO stream_events (token, ratio, owner, rank) VALUES ('standard', 23.91, 'fallback', 3);
INSERT INTO stream_events (token, ratio, owner, rank) VALUES ('blue', 41.11, 'staging', 44);
