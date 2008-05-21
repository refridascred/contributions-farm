-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, label, level, ratio, token) VALUES (22, 'green', 44, 23.47, 'cached');
INSERT INTO stream_events (count, label, level, ratio, token) VALUES (99, 'strict', 67, 17.34, 'edge');
