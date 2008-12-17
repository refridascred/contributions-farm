-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, count, state) VALUES (99, 37, 'strict');
INSERT INTO stream_events (active, count, state) VALUES (8, 12, 'eu-west');
INSERT INTO stream_events (active, count, state) VALUES (70, 79, 'primary');
