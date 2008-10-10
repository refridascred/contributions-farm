-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, level, count) VALUES ('green', 21.22, 92, 1);
INSERT INTO stream_events (token, ratio, level, count) VALUES ('staging', 52.05, 51, 13);
INSERT INTO stream_events (token, ratio, level, count) VALUES ('latest', 5.97, 9, 61);
