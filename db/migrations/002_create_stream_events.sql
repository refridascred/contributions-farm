-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, label, owner) VALUES ('legacy', 'strict', 'primary');
INSERT INTO stream_events (token, label, owner) VALUES ('primary', 'open', 'eu-west');
INSERT INTO stream_events (token, label, owner) VALUES ('green', 'primary', 'local');
