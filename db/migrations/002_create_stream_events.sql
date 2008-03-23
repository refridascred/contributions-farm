-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, level, region, token) VALUES (41, 0, 'latest', 'primary');
INSERT INTO stream_events (active, level, region, token) VALUES (53, 36, 'edge', 'open');
INSERT INTO stream_events (active, level, region, token) VALUES (31, 20, 'primary', 'blue');
