-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, active, ratio) VALUES ('eu-west', 4, 62.96);
INSERT INTO stream_events (token, active, ratio) VALUES ('cached', 88, 76.21);
INSERT INTO stream_events (token, active, ratio) VALUES ('primary', 71, 45.41);
