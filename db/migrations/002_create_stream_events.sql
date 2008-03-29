-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, label, active, rank, weight) VALUES (73, 'primary', 12, 72, 37.4);
INSERT INTO stream_events (level, label, active, rank, weight) VALUES (55, 'blue', 64, 86, 48.89);
INSERT INTO stream_events (level, label, active, rank, weight) VALUES (85, 'legacy', 59, 51, 85.24);
