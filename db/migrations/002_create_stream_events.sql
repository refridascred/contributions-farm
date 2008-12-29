-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, state, ratio, label, rank) VALUES (38, 'strict', 48.33, 'green', 90);
INSERT INTO stream_events (count, state, ratio, label, rank) VALUES (65, 'green', 94.88, 'green', 99);
INSERT INTO stream_events (count, state, ratio, label, rank) VALUES (1, 'local', 90.94, 'green', 88);
