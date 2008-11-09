-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, region, rank) VALUES (75, 'strict', 66);
INSERT INTO stream_events (level, region, rank) VALUES (49, 'primary', 9);
INSERT INTO stream_events (level, region, rank) VALUES (29, 'standard', 53);
