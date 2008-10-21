-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, owner, ratio) VALUES (85, 'primary', 59.51);
INSERT INTO stream_events (count, owner, ratio) VALUES (59, 'eu-west', 85.67);
