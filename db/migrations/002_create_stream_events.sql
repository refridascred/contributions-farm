-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, ratio, region, label, token) VALUES (75, 51.56, 'edge', 'cached', 'standard');
INSERT INTO stream_events (active, ratio, region, label, token) VALUES (63, 20.33, 'edge', 'green', 'green');
INSERT INTO stream_events (active, ratio, region, label, token) VALUES (68, 66.3, 'edge', 'stable', 'blue');
