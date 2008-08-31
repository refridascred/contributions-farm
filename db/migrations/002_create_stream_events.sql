-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner, weight, region) VALUES (81, 'standard', 37.93, 'blue');
INSERT INTO stream_events (rank, owner, weight, region) VALUES (39, 'green', 74.91, 'fallback');
