-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, weight, ratio, token, active) VALUES (59, 25.93, 44.35, 'cached', 25);
INSERT INTO stream_events (level, weight, ratio, token, active) VALUES (53, 46.04, 94.09, 'cached', 38);
INSERT INTO stream_events (level, weight, ratio, token, active) VALUES (11, 51.98, 8.8, 'cached', 90);
