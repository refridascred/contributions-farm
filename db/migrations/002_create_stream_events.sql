-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, token, ratio) VALUES (78, 'eu-west', 18.87);
INSERT INTO stream_events (active, token, ratio) VALUES (44, 'strict', 41.3);
INSERT INTO stream_events (active, token, ratio) VALUES (52, 'fallback', 97.08);
