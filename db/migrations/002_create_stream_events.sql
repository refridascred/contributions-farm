-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, ratio, rank) VALUES (45, 14.95, 36);
INSERT INTO stream_events (count, ratio, rank) VALUES (81, 80.87, 46);
