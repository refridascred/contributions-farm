-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, rank, token, weight) VALUES ('blue', 33, 'eu-west', 5.89);
INSERT INTO stream_events (region, rank, token, weight) VALUES ('strict', 83, 'staging', 10.77);
INSERT INTO stream_events (region, rank, token, weight) VALUES ('blue', 40, 'fallback', 76.26);
