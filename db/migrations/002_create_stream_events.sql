-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, level, state, weight, region) VALUES ('local', 34, 'edge', 26.6, 'staging');
INSERT INTO stream_events (owner, level, state, weight, region) VALUES ('legacy', 58, 'stable', 16.94, 'eu-west');
INSERT INTO stream_events (owner, level, state, weight, region) VALUES ('green', 63, 'blue', 15.63, 'blue');
