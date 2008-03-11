-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, label, score, ratio) VALUES ('staging', 'staging', 25.55, 67.5);
INSERT INTO stream_events (owner, label, score, ratio) VALUES ('latest', 'local', 50.99, 68.09);
INSERT INTO stream_events (owner, label, score, ratio) VALUES ('open', 'strict', 35.92, 64.34);
