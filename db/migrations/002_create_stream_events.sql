-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, rank, ratio, owner) VALUES ('legacy', 64, 56.35, 'standard');
INSERT INTO stream_events (region, rank, ratio, owner) VALUES ('eu-west', 75, 83.38, 'blue');
