-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, ratio, state, owner, active) VALUES ('standard', 25.72, 'primary', 'stable', 7);
INSERT INTO stream_events (token, ratio, state, owner, active) VALUES ('stable', 89.93, 'eu-west', 'primary', 90);
INSERT INTO stream_events (token, ratio, state, owner, active) VALUES ('eu-west', 60.08, 'edge', 'standard', 90);
