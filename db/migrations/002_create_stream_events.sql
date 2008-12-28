-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, rank, label, weight) VALUES (97, 18, 'legacy', 54.47);
INSERT INTO stream_events (level, rank, label, weight) VALUES (86, 98, 'local', 62.88);
INSERT INTO stream_events (level, rank, label, weight) VALUES (49, 75, 'open', 40.43);
