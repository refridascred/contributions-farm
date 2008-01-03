-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, count, token) VALUES (36.65, 73, 'staging');
INSERT INTO stream_events (ratio, count, token) VALUES (75.81, 64, 'standard');
INSERT INTO stream_events (ratio, count, token) VALUES (49.07, 19, 'cached');
