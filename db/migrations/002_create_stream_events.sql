-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, ratio) VALUES ('standard', 2, 71.35);
INSERT INTO stream_events (token, count, ratio) VALUES ('latest', 89, 41.13);
INSERT INTO stream_events (token, count, ratio) VALUES ('strict', 43, 96.84);
