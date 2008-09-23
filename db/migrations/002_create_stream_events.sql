-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, weight, level) VALUES ('legacy', 58.33, 30);
INSERT INTO stream_events (token, weight, level) VALUES ('strict', 12.33, 63);
INSERT INTO stream_events (token, weight, level) VALUES ('legacy', 30.17, 80);
