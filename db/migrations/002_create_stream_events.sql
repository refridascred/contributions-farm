-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, owner, weight) VALUES ('strict', 'strict', 37.71);
INSERT INTO stream_events (token, owner, weight) VALUES ('staging', 'stable', 41.25);
INSERT INTO stream_events (token, owner, weight) VALUES ('primary', 'fallback', 58.77);
