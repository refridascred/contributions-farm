-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, weight, count) VALUES ('eu-west', 90.11, 72);
INSERT INTO stream_events (token, weight, count) VALUES ('strict', 81.83, 56);
INSERT INTO stream_events (token, weight, count) VALUES ('standard', 21.53, 80);
