-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, owner, level, token, weight) VALUES ('primary', 'strict', 26, 'legacy', 50.17);
INSERT INTO stream_events (label, owner, level, token, weight) VALUES ('legacy', 'open', 94, 'strict', 27.66);
