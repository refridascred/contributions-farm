-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, weight, active) VALUES ('standard', 32.79, 49);
INSERT INTO stream_events (token, weight, active) VALUES ('standard', 32.24, 71);
INSERT INTO stream_events (token, weight, active) VALUES ('edge', 70.94, 47);
