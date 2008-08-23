-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, rank, state, token, label) VALUES (95, 71, 'cached', 'blue', 'edge');
INSERT INTO stream_events (level, rank, state, token, label) VALUES (10, 32, 'local', 'standard', 'latest');
INSERT INTO stream_events (level, rank, state, token, label) VALUES (32, 71, 'staging', 'primary', 'open');
