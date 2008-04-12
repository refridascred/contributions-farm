-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, count, state, label, rank) VALUES (88, 47, 'green', 'blue', 73);
INSERT INTO stream_events (active, count, state, label, rank) VALUES (21, 26, 'fallback', 'primary', 93);
