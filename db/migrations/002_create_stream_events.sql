-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, count, label, active, owner) VALUES (24, 29, 'primary', 62, 'eu-west');
INSERT INTO stream_events (rank, count, label, active, owner) VALUES (28, 69, 'cached', 40, 'blue');
