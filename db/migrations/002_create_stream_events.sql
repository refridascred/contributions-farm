-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, owner, level, region) VALUES ('primary', 'latest', 76, 'legacy');
INSERT INTO stream_events (label, owner, level, region) VALUES ('green', 'cached', 70, 'local');
