-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, rank, label, active) VALUES ('open', 84, 'stable', 80);
INSERT INTO stream_events (owner, rank, label, active) VALUES ('staging', 36, 'latest', 3);
INSERT INTO stream_events (owner, rank, label, active) VALUES ('standard', 1, 'standard', 16);
