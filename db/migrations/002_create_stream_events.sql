-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, token, label, ratio) VALUES ('primary', 'open', 'staging', 80.91);
INSERT INTO stream_events (owner, token, label, ratio) VALUES ('fallback', 'blue', 'staging', 36.56);
INSERT INTO stream_events (owner, token, label, ratio) VALUES ('standard', 'stable', 'staging', 3.33);
