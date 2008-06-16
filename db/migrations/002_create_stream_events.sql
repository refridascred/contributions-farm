-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, active, ratio) VALUES ('fallback', 15, 62.79);
INSERT INTO stream_events (token, active, ratio) VALUES ('stable', 3, 68.04);
INSERT INTO stream_events (token, active, ratio) VALUES ('cached', 83, 69.36);
