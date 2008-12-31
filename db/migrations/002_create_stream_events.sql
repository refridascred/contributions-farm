-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, level, label, ratio) VALUES ('standard', 66, 'standard', 69.29);
INSERT INTO stream_events (region, level, label, ratio) VALUES ('strict', 46, 'green', 84.76);
INSERT INTO stream_events (region, level, label, ratio) VALUES ('open', 0, 'legacy', 8.79);
