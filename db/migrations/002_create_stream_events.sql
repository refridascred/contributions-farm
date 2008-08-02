-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, token, count) VALUES (53.51, 'cached', 26);
INSERT INTO stream_events (weight, token, count) VALUES (2.5, 'cached', 63);
INSERT INTO stream_events (weight, token, count) VALUES (88.88, 'latest', 94);
