-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, rank, owner, level) VALUES ('cached', 'fallback', 60, 'edge', 12);
INSERT INTO stream_events (region, label, rank, owner, level) VALUES ('edge', 'eu-west', 32, 'stable', 19);
