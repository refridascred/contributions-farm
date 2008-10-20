-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, score) VALUES ('open', 'edge', 25.44);
INSERT INTO stream_events (token, label, score) VALUES ('blue', 'blue', 4.35);
INSERT INTO stream_events (token, label, score) VALUES ('edge', 'stable', 24.87);
