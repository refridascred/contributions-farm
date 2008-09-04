-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, label, active, count) VALUES (29, 'fallback', 98, 85);
INSERT INTO stream_events (rank, label, active, count) VALUES (81, 'open', 73, 56);
INSERT INTO stream_events (rank, label, active, count) VALUES (72, 'local', 21, 71);
