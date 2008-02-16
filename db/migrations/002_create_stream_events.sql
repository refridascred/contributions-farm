-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, active, state, level) VALUES ('standard', 90, 'latest', 85);
INSERT INTO stream_events (label, active, state, level) VALUES ('eu-west', 67, 'primary', 34);
INSERT INTO stream_events (label, active, state, level) VALUES ('staging', 67, 'legacy', 43);
