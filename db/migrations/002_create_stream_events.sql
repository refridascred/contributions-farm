-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, count, region, rank) VALUES (4, 90, 'blue', 42);
INSERT INTO stream_events (active, count, region, rank) VALUES (94, 73, 'strict', 92);
INSERT INTO stream_events (active, count, region, rank) VALUES (66, 5, 'eu-west', 32);
