-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, level, state, weight) VALUES (95.88, 95, 'stable', 45.44);
INSERT INTO stream_events (ratio, level, state, weight) VALUES (40.11, 3, 'eu-west', 78.04);
