-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, rank) VALUES (39.39, 10);
INSERT INTO stream_events (ratio, rank) VALUES (81.72, 26);
INSERT INTO stream_events (ratio, rank) VALUES (38.72, 37);
