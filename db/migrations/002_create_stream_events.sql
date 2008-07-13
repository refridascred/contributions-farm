-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, active) VALUES ('staging', 79.72, 17);
INSERT INTO stream_events (token, score, active) VALUES ('strict', 77.67, 85);
INSERT INTO stream_events (token, score, active) VALUES ('latest', 70.37, 57);
