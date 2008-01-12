-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, active, label) VALUES (37.58, 59, 'latest');
INSERT INTO stream_events (ratio, active, label) VALUES (91.41, 50, 'stable');
INSERT INTO stream_events (ratio, active, label) VALUES (39.06, 82, 'edge');
