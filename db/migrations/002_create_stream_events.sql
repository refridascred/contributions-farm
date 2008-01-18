-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, owner, label, weight) VALUES ('eu-west', 'stable', 'green', 24.55);
INSERT INTO stream_events (token, owner, label, weight) VALUES ('cached', 'legacy', 'local', 81.54);
INSERT INTO stream_events (token, owner, label, weight) VALUES ('open', 'cached', 'blue', 0.61);
