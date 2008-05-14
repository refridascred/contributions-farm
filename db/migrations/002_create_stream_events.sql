-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, state, active, level, token) VALUES (89, 'stable', 57, 83, 'staging');
INSERT INTO stream_events (rank, state, active, level, token) VALUES (16, 'eu-west', 93, 75, 'latest');
