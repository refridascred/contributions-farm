-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, level, weight, token) VALUES (26, 15, 39.84, 'latest');
INSERT INTO stream_events (count, level, weight, token) VALUES (17, 68, 83.09, 'green');
INSERT INTO stream_events (count, level, weight, token) VALUES (89, 68, 24.21, 'staging');
