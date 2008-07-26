-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, weight, owner) VALUES (95.21, 18.57, 'standard');
INSERT INTO stream_events (ratio, weight, owner) VALUES (35.34, 28.67, 'fallback');
