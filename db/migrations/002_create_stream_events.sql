-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, level, ratio) VALUES ('green', 70, 29.06);
INSERT INTO stream_events (region, level, ratio) VALUES ('eu-west', 29, 46.1);
INSERT INTO stream_events (region, level, ratio) VALUES ('strict', 54, 13.76);
