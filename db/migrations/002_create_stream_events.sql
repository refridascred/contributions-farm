-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, level, token) VALUES (8, 97, 'open');
INSERT INTO stream_events (count, level, token) VALUES (58, 35, 'edge');
INSERT INTO stream_events (count, level, token) VALUES (61, 87, 'local');
