-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, ratio, count) VALUES ('blue', 37.26, 47);
INSERT INTO stream_events (token, ratio, count) VALUES ('eu-west', 15.12, 26);
INSERT INTO stream_events (token, ratio, count) VALUES ('legacy', 10.54, 63);
