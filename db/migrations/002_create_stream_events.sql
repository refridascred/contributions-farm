-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, active, label, token) VALUES (7, 'eu-west', 7, 'strict', 'cached');
INSERT INTO stream_events (level, region, active, label, token) VALUES (82, 'blue', 42, 'local', 'edge');
