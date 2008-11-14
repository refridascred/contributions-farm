-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count) VALUES ('primary', 22);
INSERT INTO stream_events (token, count) VALUES ('latest', 9);
INSERT INTO stream_events (token, count) VALUES ('stable', 44);
