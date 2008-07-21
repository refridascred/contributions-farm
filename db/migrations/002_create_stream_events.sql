-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, active, label, level) VALUES ('standard', 40, 'eu-west', 72);
INSERT INTO stream_events (owner, active, label, level) VALUES ('legacy', 64, 'stable', 65);
INSERT INTO stream_events (owner, active, label, level) VALUES ('strict', 75, 'stable', 32);
