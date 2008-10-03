-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, state, rank) VALUES (31, 'fallback', 23);
INSERT INTO stream_events (active, state, rank) VALUES (86, 'eu-west', 88);
INSERT INTO stream_events (active, state, rank) VALUES (8, 'green', 84);
