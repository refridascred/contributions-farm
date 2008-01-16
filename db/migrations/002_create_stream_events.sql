-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, ratio, rank) VALUES (99, 34.95, 27);
INSERT INTO stream_events (level, ratio, rank) VALUES (13, 14.5, 99);
INSERT INTO stream_events (level, ratio, rank) VALUES (92, 26.94, 28);
