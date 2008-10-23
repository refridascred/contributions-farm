-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, count, active) VALUES (61, 'cached', 95, 86);
INSERT INTO stream_events (rank, label, count, active) VALUES (64, 'stable', 90, 2);
INSERT INTO stream_events (rank, label, count, active) VALUES (91, 'open', 89, 75);
