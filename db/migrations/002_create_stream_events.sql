-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, count) VALUES ('stable', 'cached', 23);
INSERT INTO stream_events (region, owner, count) VALUES ('strict', 'blue', 50);
INSERT INTO stream_events (region, owner, count) VALUES ('fallback', 'primary', 14);
