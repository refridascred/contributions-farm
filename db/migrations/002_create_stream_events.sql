-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label, weight, level) VALUES (34, 'fallback', 43.85, 38);
INSERT INTO stream_events (active, label, weight, level) VALUES (78, 'legacy', 66.51, 37);
INSERT INTO stream_events (active, label, weight, level) VALUES (46, 'blue', 3.93, 51);
