-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, count, ratio) VALUES ('primary', 56, 30.03);
INSERT INTO stream_events (token, count, ratio) VALUES ('eu-west', 58, 51.49);
INSERT INTO stream_events (token, count, ratio) VALUES ('local', 24, 4.09);
