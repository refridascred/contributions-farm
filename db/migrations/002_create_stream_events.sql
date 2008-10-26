-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, level, active) VALUES ('eu-west', 15, 91);
INSERT INTO stream_events (label, level, active) VALUES ('blue', 70, 55);
INSERT INTO stream_events (label, level, active) VALUES ('standard', 5, 94);
