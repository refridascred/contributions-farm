-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, region, weight, count, rank) VALUES (29, 'green', 79.83, 28, 94);
INSERT INTO stream_events (active, region, weight, count, rank) VALUES (64, 'latest', 13.91, 41, 68);
