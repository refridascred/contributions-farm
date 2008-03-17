-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, label, score, rank) VALUES ('standard', 53, 'eu-west', 65.97, 88);
INSERT INTO stream_events (region, level, label, score, rank) VALUES ('primary', 60, 'eu-west', 13.93, 79);
