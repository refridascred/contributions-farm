-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, ratio, rank) VALUES (32, 91.37, 6);
INSERT INTO stream_events (level, ratio, rank) VALUES (14, 92.73, 12);
