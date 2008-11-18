-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, owner) VALUES (13, 67.11, 'legacy');
INSERT INTO stream_events (level, weight, owner) VALUES (87, 89.15, 'open');
INSERT INTO stream_events (level, weight, owner) VALUES (6, 24.82, 'standard');
