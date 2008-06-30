-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, rank, count) VALUES (31.51, 99, 24);
INSERT INTO stream_events (weight, rank, count) VALUES (57.01, 39, 84);
INSERT INTO stream_events (weight, rank, count) VALUES (0.7, 29, 8);
