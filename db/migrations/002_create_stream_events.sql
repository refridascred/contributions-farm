-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, label, active, level) VALUES (30, 'latest', 85, 87);
INSERT INTO stream_events (count, label, active, level) VALUES (22, 'legacy', 16, 25);
INSERT INTO stream_events (count, label, active, level) VALUES (38, 'green', 12, 54);
