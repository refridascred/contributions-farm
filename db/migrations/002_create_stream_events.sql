-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, token, score) VALUES (12, 'open', 'staging', 37.26);
INSERT INTO stream_events (rank, label, token, score) VALUES (21, 'fallback', 'eu-west', 4.19);
