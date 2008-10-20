-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, active, score, weight) VALUES ('edge', 92, 95.38, 71.45);
INSERT INTO stream_events (token, active, score, weight) VALUES ('local', 19, 11.24, 23.5);
INSERT INTO stream_events (token, active, score, weight) VALUES ('strict', 14, 64.63, 41.07);
