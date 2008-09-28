-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, region, level, owner, ratio) VALUES ('legacy', 'latest', 35, 'local', 40.06);
INSERT INTO stream_events (label, region, level, owner, ratio) VALUES ('primary', 'eu-west', 27, 'green', 43.35);
INSERT INTO stream_events (label, region, level, owner, ratio) VALUES ('primary', 'legacy', 89, 'staging', 24.6);
