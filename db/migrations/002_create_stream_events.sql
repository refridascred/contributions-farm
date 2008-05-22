-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, token) VALUES ('primary', 'latest', 'local');
INSERT INTO stream_events (owner, label, token) VALUES ('eu-west', 'cached', 'legacy');
INSERT INTO stream_events (owner, label, token) VALUES ('legacy', 'strict', 'staging');
