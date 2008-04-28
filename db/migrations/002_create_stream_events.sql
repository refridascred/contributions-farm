-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, owner, rank) VALUES ('eu-west', 'stable', 59);
