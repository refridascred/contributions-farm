-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, label, active, ratio) VALUES (38.54, 'staging', 39, 87.0);
INSERT INTO stream_events (weight, label, active, ratio) VALUES (98.12, 'stable', 35, 84.88);
INSERT INTO stream_events (weight, label, active, ratio) VALUES (32.26, 'legacy', 27, 97.39);
