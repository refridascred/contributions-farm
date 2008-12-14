-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, ratio, owner, count) VALUES (43.38, 62.68, 'open', 62);
INSERT INTO stream_events (weight, ratio, owner, count) VALUES (66.45, 42.81, 'legacy', 63);
