-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, label, token, rank) VALUES (11, 'blue', 'local', 9);
INSERT INTO stream_events (count, label, token, rank) VALUES (7, 'primary', 'edge', 59);
