-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, ratio, region, state) VALUES (61, 40.32, 'eu-west', 'standard');
INSERT INTO stream_events (count, ratio, region, state) VALUES (79, 90.61, 'eu-west', 'staging');
