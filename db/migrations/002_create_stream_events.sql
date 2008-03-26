-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio) VALUES (96, 92.71);
INSERT INTO stream_events (count, ratio) VALUES (35, 73.1);
INSERT INTO stream_events (count, ratio) VALUES (96, 41.05);
