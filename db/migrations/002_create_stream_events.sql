-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, token, label) VALUES (3.12, 'legacy', 'eu-west');
INSERT INTO stream_events (score, token, label) VALUES (43.65, 'strict', 'open');
INSERT INTO stream_events (score, token, label) VALUES (63.05, 'green', 'standard');
