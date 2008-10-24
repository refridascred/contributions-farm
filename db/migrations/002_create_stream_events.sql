-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label, rank) VALUES (18, 'legacy', 63);
INSERT INTO stream_events (active, label, rank) VALUES (81, 'latest', 3);
INSERT INTO stream_events (active, label, rank) VALUES (51, 'green', 78);
