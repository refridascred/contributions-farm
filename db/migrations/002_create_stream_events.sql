-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region, state) VALUES (52, 'legacy', 'stable');
INSERT INTO stream_events (count, region, state) VALUES (33, 'staging', 'green');
INSERT INTO stream_events (count, region, state) VALUES (24, 'green', 'staging');
