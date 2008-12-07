-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, state, ratio) VALUES (57, 22.93, 'staging', 77.12);
INSERT INTO stream_events (level, weight, state, ratio) VALUES (58, 28.83, 'stable', 73.88);
INSERT INTO stream_events (level, weight, state, ratio) VALUES (53, 71.99, 'primary', 59.32);
