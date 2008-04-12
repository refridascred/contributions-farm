-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, region, rank) VALUES ('primary', 'eu-west', 64);
INSERT INTO stream_events (state, region, rank) VALUES ('fallback', 'staging', 72);
INSERT INTO stream_events (state, region, rank) VALUES ('fallback', 'staging', 58);
