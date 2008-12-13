-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, owner) VALUES ('stable', 'latest', 'local');
INSERT INTO stream_events (token, label, owner) VALUES ('latest', 'green', 'legacy');
INSERT INTO stream_events (token, label, owner) VALUES ('open', 'cached', 'staging');
