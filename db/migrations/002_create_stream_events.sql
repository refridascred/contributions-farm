-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, rank) VALUES ('blue', 'blue', 59);
INSERT INTO stream_events (region, owner, rank) VALUES ('staging', 'blue', 59);
INSERT INTO stream_events (region, owner, rank) VALUES ('local', 'fallback', 64);
