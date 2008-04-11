-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, token, rank, weight) VALUES (3.95, 'legacy', 16, 22.97);
INSERT INTO stream_events (ratio, token, rank, weight) VALUES (62.04, 'strict', 30, 16.88);
