-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank) VALUES (60.82, 99);
INSERT INTO stream_events (ratio, rank) VALUES (80.85, 14);
INSERT INTO stream_events (ratio, rank) VALUES (33.29, 98);
