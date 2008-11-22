-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, label) VALUES ('eu-west', 25.88, 'stable');
INSERT INTO stream_events (owner, weight, label) VALUES ('legacy', 57.75, 'strict');
INSERT INTO stream_events (owner, weight, label) VALUES ('legacy', 66.43, 'staging');
