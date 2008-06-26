-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region, owner, active, ratio) VALUES (20, 'strict', 'strict', 83, 55.83);
INSERT INTO stream_events (count, region, owner, active, ratio) VALUES (37, 'blue', 'strict', 12, 52.71);
