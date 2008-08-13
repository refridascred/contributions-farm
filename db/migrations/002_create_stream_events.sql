-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, owner, label) VALUES ('stable', 'staging', 'cached');
INSERT INTO stream_events (token, owner, label) VALUES ('primary', 'open', 'legacy');
INSERT INTO stream_events (token, owner, label) VALUES ('cached', 'local', 'cached');
