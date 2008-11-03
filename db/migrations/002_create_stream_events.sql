-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, region, active) VALUES (60, 'edge', 24);
INSERT INTO stream_events (level, region, active) VALUES (51, 'eu-west', 75);
INSERT INTO stream_events (level, region, active) VALUES (1, 'blue', 41);
