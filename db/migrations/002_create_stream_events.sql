-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, weight, level, region) VALUES ('stable', 'cached', 8.8, 53, 'cached');
INSERT INTO stream_events (token, label, weight, level, region) VALUES ('staging', 'fallback', 41.91, 99, 'primary');
INSERT INTO stream_events (token, label, weight, level, region) VALUES ('stable', 'cached', 47.31, 74, 'stable');
