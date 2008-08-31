-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, label) VALUES (33, 48.27, 'staging');
INSERT INTO stream_events (level, weight, label) VALUES (45, 40.33, 'primary');
INSERT INTO stream_events (level, weight, label) VALUES (21, 82.5, 'edge');
