-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, active, ratio, level) VALUES (35.88, 88, 5.96, 3);
INSERT INTO stream_events (weight, active, ratio, level) VALUES (88.64, 2, 71.81, 54);
INSERT INTO stream_events (weight, active, ratio, level) VALUES (48.85, 58, 58.29, 85);
