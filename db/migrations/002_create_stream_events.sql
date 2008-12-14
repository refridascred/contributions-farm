-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, active, ratio, label) VALUES (68.73, 54, 26.22, 'cached');
INSERT INTO stream_events (weight, active, ratio, label) VALUES (61.21, 67, 71.31, 'cached');
