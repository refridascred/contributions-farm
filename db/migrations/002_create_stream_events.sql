-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, token, count) VALUES ('strict', 'primary', 21);
INSERT INTO stream_events (region, token, count) VALUES ('latest', 'strict', 77);
INSERT INTO stream_events (region, token, count) VALUES ('stable', 'eu-west', 67);
