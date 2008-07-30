-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, ratio, rank, level) VALUES ('eu-west', 19.76, 90, 63);
INSERT INTO stream_events (region, ratio, rank, level) VALUES ('cached', 42.45, 32, 70);
INSERT INTO stream_events (region, ratio, rank, level) VALUES ('primary', 53.78, 35, 68);
