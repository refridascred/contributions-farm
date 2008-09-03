-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, label, count, rank) VALUES (37, 'cached', 68, 79);
INSERT INTO stream_events (active, label, count, rank) VALUES (0, 'blue', 42, 63);
INSERT INTO stream_events (active, label, count, rank) VALUES (0, 'primary', 75, 82);
