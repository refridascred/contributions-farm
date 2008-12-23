-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, rank, active) VALUES (12, 17, 24);
INSERT INTO stream_events (count, rank, active) VALUES (71, 26, 55);
INSERT INTO stream_events (count, rank, active) VALUES (9, 6, 93);
