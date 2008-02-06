-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region) VALUES (29, 'staging');
INSERT INTO stream_events (count, region) VALUES (45, 'local');
INSERT INTO stream_events (count, region) VALUES (81, 'fallback');
