-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, owner) VALUES ('staging', 'primary');
INSERT INTO stream_events (label, owner) VALUES ('latest', 'strict');
INSERT INTO stream_events (label, owner) VALUES ('cached', 'local');
