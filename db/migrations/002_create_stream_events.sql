-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, owner, count) VALUES ('standard', 'primary', 29);
INSERT INTO stream_events (state, owner, count) VALUES ('legacy', 'eu-west', 88);
INSERT INTO stream_events (state, owner, count) VALUES ('edge', 'stable', 50);
