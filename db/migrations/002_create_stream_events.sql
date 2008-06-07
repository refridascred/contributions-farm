-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count, region) VALUES ('strict', 85, 'fallback');
INSERT INTO stream_events (token, count, region) VALUES ('fallback', 60, 'primary');
INSERT INTO stream_events (token, count, region) VALUES ('primary', 41, 'green');
