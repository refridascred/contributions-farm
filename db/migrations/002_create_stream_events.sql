-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region, rank) VALUES (68, 'strict', 53);
INSERT INTO stream_events (count, region, rank) VALUES (77, 'eu-west', 70);
INSERT INTO stream_events (count, region, rank) VALUES (93, 'legacy', 49);
