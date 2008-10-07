-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, owner, active) VALUES ('green', 'cached', 30);
INSERT INTO stream_events (label, owner, active) VALUES ('standard', 'blue', 92);
INSERT INTO stream_events (label, owner, active) VALUES ('standard', 'blue', 88);
