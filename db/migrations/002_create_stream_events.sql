-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, token, label, active) VALUES (85, 'legacy', 'legacy', 1);
INSERT INTO stream_events (rank, token, label, active) VALUES (62, 'latest', 'legacy', 32);
