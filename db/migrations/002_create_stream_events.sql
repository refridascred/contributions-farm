-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, weight, ratio) VALUES ('strict', 62.0, 68.54);
INSERT INTO stream_events (token, weight, ratio) VALUES ('stable', 22.81, 84.05);
INSERT INTO stream_events (token, weight, ratio) VALUES ('cached', 19.82, 0.33);
