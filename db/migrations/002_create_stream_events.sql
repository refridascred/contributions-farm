-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, label) VALUES (37, 1.52, 'latest');
INSERT INTO stream_events (level, weight, label) VALUES (81, 4.16, 'edge');
