-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, rank, weight, label) VALUES (67, 34, 32.6, 'green');
INSERT INTO stream_events (active, rank, weight, label) VALUES (35, 75, 5.76, 'strict');
