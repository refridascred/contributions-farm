-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region, owner) VALUES (10, 'primary', 'legacy');
INSERT INTO stream_events (count, region, owner) VALUES (67, 'standard', 'green');
INSERT INTO stream_events (count, region, owner) VALUES (27, 'local', 'staging');
