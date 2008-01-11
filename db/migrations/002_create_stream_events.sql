-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, active) VALUES (13, 'green', 10);
INSERT INTO stream_events (level, region, active) VALUES (61, 'latest', 5);
INSERT INTO stream_events (level, region, active) VALUES (84, 'legacy', 94);
