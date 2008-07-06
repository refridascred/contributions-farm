-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, weight, owner) VALUES (8, 92.9, 'fallback');
INSERT INTO stream_events (level, weight, owner) VALUES (29, 86.83, 'fallback');
INSERT INTO stream_events (level, weight, owner) VALUES (51, 20.26, 'staging');
