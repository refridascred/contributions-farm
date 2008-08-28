-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, token, label, active) VALUES (61, 'cached', 'blue', 28);
INSERT INTO stream_events (rank, token, label, active) VALUES (91, 'latest', 'open', 6);
