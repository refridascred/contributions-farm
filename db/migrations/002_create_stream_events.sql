-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, label, state, region, level) VALUES (0, 'staging', 'local', 'blue', 47);
INSERT INTO stream_events (rank, label, state, region, level) VALUES (69, 'legacy', 'edge', 'eu-west', 95);
INSERT INTO stream_events (rank, label, state, region, level) VALUES (0, 'legacy', 'cached', 'legacy', 19);
