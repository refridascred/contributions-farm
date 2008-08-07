-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, owner, weight) VALUES ('stable', 'open', 26.66);
INSERT INTO stream_events (token, owner, weight) VALUES ('primary', 'local', 35.59);
INSERT INTO stream_events (token, owner, weight) VALUES ('edge', 'strict', 55.93);
