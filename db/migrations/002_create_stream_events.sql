-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, token, rank, level) VALUES (25.45, 'fallback', 7, 2);
INSERT INTO stream_events (weight, token, rank, level) VALUES (60.11, 'latest', 8, 35);
