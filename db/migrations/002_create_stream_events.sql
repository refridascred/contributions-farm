-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, token, label) VALUES (43, 10.69, 'latest', 'cached');
INSERT INTO stream_events (count, ratio, token, label) VALUES (60, 32.04, 'stable', 'edge');
INSERT INTO stream_events (count, ratio, token, label) VALUES (60, 96.62, 'standard', 'stable');
