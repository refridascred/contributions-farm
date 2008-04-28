-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, count, score) VALUES (63.54, 43, 16.0);
INSERT INTO stream_events (weight, count, score) VALUES (45.29, 95, 89.83);
INSERT INTO stream_events (weight, count, score) VALUES (14.11, 17, 86.75);
