-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, token, ratio) VALUES (80, 'eu-west', 50.07);
INSERT INTO stream_events (count, token, ratio) VALUES (94, 'latest', 63.39);
INSERT INTO stream_events (count, token, ratio) VALUES (42, 'legacy', 55.45);
