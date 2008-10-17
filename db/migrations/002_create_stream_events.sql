-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, count, label) VALUES (41, 81, 'primary');
INSERT INTO stream_events (level, count, label) VALUES (35, 82, 'legacy');
INSERT INTO stream_events (level, count, label) VALUES (8, 83, 'edge');
