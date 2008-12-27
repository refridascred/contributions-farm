-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, token, rank, label) VALUES (8, 'green', 77, 'stable');
INSERT INTO stream_events (count, token, rank, label) VALUES (65, 'legacy', 85, 'standard');
