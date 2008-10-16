-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, count, token) VALUES (12, 70, 'staging');
INSERT INTO stream_events (level, count, token) VALUES (20, 75, 'blue');
INSERT INTO stream_events (level, count, token) VALUES (29, 30, 'green');
