-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, weight, owner, label) VALUES (19, 86.85, 'primary', 'open');
INSERT INTO stream_events (active, weight, owner, label) VALUES (69, 59.77, 'open', 'stable');
