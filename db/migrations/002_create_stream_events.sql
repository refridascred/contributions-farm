-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count, active, ratio) VALUES ('local', 32, 94, 41.87);
INSERT INTO stream_events (token, count, active, ratio) VALUES ('latest', 37, 70, 65.41);
INSERT INTO stream_events (token, count, active, ratio) VALUES ('staging', 72, 52, 52.65);
