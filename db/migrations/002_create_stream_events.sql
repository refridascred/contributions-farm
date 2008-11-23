-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label) VALUES ('blue', 'legacy');
INSERT INTO stream_events (owner, label) VALUES ('legacy', 'strict');
INSERT INTO stream_events (owner, label) VALUES ('stable', 'stable');
