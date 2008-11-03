-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, active, state, rank) VALUES ('open', 63, 'local', 62);
INSERT INTO stream_events (owner, active, state, rank) VALUES ('standard', 41, 'local', 29);
INSERT INTO stream_events (owner, active, state, rank) VALUES ('eu-west', 54, 'standard', 3);
