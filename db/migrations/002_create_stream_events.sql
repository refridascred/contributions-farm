-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, count, label) VALUES (62.37, 86.04, 90, 'open');
INSERT INTO stream_events (ratio, weight, count, label) VALUES (87.61, 60.52, 12, 'blue');
INSERT INTO stream_events (ratio, weight, count, label) VALUES (48.9, 68.03, 66, 'cached');
