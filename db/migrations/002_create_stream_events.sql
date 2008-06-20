-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, ratio, token, label, owner) VALUES (65.37, 45.0, 'primary', 'blue', 'cached');
INSERT INTO stream_events (weight, ratio, token, label, owner) VALUES (74.06, 33.33, 'open', 'strict', 'cached');
INSERT INTO stream_events (weight, ratio, token, label, owner) VALUES (62.77, 3.39, 'eu-west', 'legacy', 'stable');
