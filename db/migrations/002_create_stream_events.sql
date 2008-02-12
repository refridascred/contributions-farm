-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, level) VALUES (86.78, 90);
INSERT INTO stream_events (ratio, level) VALUES (64.0, 4);
INSERT INTO stream_events (ratio, level) VALUES (38.61, 30);
