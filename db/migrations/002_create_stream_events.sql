-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, rank) VALUES (6.3, 36);
INSERT INTO stream_events (ratio, rank) VALUES (1.86, 41);
INSERT INTO stream_events (ratio, rank) VALUES (76.29, 25);
