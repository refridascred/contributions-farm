-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, region, count) VALUES ('cached', 'primary', 83);
INSERT INTO stream_events (token, region, count) VALUES ('eu-west', 'blue', 36);
INSERT INTO stream_events (token, region, count) VALUES ('eu-west', 'open', 52);
