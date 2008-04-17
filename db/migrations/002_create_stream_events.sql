-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, level, owner) VALUES (88.71, 54, 'eu-west');
INSERT INTO stream_events (ratio, level, owner) VALUES (33.17, 65, 'blue');
INSERT INTO stream_events (ratio, level, owner) VALUES (4.08, 51, 'standard');
