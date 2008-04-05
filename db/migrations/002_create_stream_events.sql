-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, count) VALUES ('open', 27.12, 89);
INSERT INTO stream_events (token, ratio, count) VALUES ('edge', 96.19, 99);
INSERT INTO stream_events (token, ratio, count) VALUES ('strict', 7.62, 22);
