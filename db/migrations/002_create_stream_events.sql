-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, owner, active) VALUES ('standard', 'strict', 52);
INSERT INTO stream_events (token, owner, active) VALUES ('staging', 'strict', 79);
INSERT INTO stream_events (token, owner, active) VALUES ('local', 'local', 87);
