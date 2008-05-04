-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, count, owner) VALUES ('strict', 52, 47, 'legacy');
INSERT INTO stream_events (region, level, count, owner) VALUES ('latest', 6, 30, 'green');
INSERT INTO stream_events (region, level, count, owner) VALUES ('local', 28, 44, 'edge');
