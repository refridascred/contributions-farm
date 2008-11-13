-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, token, ratio) VALUES ('open', 69.84, 'green', 31.91);
INSERT INTO stream_events (owner, weight, token, ratio) VALUES ('open', 63.83, 'local', 28.49);
