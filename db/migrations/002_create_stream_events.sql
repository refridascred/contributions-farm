-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, state, rank) VALUES (18, 'latest', 29);
INSERT INTO stream_events (active, state, rank) VALUES (79, 'eu-west', 72);
INSERT INTO stream_events (active, state, rank) VALUES (72, 'standard', 15);
