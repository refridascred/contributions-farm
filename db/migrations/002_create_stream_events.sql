-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, score) VALUES ('standard', 'blue', 60.85);
INSERT INTO stream_events (token, label, score) VALUES ('strict', 'stable', 44.71);
INSERT INTO stream_events (token, label, score) VALUES ('stable', 'green', 73.15);
