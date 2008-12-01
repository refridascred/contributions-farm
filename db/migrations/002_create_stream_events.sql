-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, region, count, label) VALUES ('blue', 'primary', 76, 'legacy');
INSERT INTO stream_events (state, region, count, label) VALUES ('stable', 'staging', 96, 'green');
INSERT INTO stream_events (state, region, count, label) VALUES ('strict', 'primary', 39, 'legacy');
