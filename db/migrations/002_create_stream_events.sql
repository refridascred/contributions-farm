-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, rank) VALUES ('latest', 78);
INSERT INTO stream_events (region, rank) VALUES ('green', 94);
INSERT INTO stream_events (region, rank) VALUES ('eu-west', 92);
