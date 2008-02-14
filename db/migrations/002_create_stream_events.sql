-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count, owner, ratio) VALUES (11.15, 42, 'eu-west', 30.53);
INSERT INTO stream_events (weight, count, owner, ratio) VALUES (48.08, 67, 'open', 13.42);
