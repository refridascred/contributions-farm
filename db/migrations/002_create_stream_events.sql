-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, label, weight, active, region) VALUES (95.78, 'legacy', 5.65, 44, 'local');
INSERT INTO stream_events (ratio, label, weight, active, region) VALUES (76.5, 'staging', 51.41, 81, 'primary');
INSERT INTO stream_events (ratio, label, weight, active, region) VALUES (97.67, 'standard', 60.72, 24, 'primary');
