-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, label, ratio, count) VALUES ('local', 'strict', 5.51, 57);
INSERT INTO stream_events (token, label, ratio, count) VALUES ('cached', 'latest', 17.82, 36);
