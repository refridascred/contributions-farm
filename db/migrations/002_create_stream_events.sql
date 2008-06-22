-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, state, region) VALUES (70, 8, 'staging', 'fallback');
INSERT INTO stream_events (rank, level, state, region) VALUES (9, 53, 'fallback', 'eu-west');
INSERT INTO stream_events (rank, level, state, region) VALUES (82, 18, 'latest', 'blue');
