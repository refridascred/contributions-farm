-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, active, region, count, rank) VALUES (11.91, 65, 'cached', 8, 65);
INSERT INTO stream_events (weight, active, region, count, rank) VALUES (5.14, 60, 'legacy', 19, 50);
