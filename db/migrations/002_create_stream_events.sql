-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, active, level) VALUES ('open', 3, 76);
INSERT INTO stream_events (owner, active, level) VALUES ('cached', 41, 63);
INSERT INTO stream_events (owner, active, level) VALUES ('legacy', 56, 87);
