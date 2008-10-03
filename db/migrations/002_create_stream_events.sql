-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, level, active) VALUES ('primary', 13, 67);
INSERT INTO stream_events (label, level, active) VALUES ('blue', 1, 88);
INSERT INTO stream_events (label, level, active) VALUES ('open', 1, 82);
