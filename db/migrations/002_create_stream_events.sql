-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, owner, region) VALUES (31, 'green', 'green');
INSERT INTO stream_events (count, owner, region) VALUES (80, 'fallback', 'fallback');
INSERT INTO stream_events (count, owner, region) VALUES (86, 'fallback', 'local');
