-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, owner, score, label, state) VALUES ('primary', 'staging', 74.74, 'legacy', 'legacy');
INSERT INTO stream_events (token, owner, score, label, state) VALUES ('primary', 'strict', 60.74, 'eu-west', 'legacy');
