-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, label, active) VALUES (30, 'primary', 39);
INSERT INTO stream_events (count, label, active) VALUES (56, 'primary', 37);
INSERT INTO stream_events (count, label, active) VALUES (48, 'local', 24);
