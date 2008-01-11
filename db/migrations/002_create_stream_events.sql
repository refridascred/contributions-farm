-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, owner, weight) VALUES (6, 'cached', 87.35);
INSERT INTO stream_events (level, owner, weight) VALUES (29, 'legacy', 95.46);
