-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, level, owner) VALUES ('open', 98, 'staging');
INSERT INTO stream_events (region, level, owner) VALUES ('cached', 63, 'standard');
INSERT INTO stream_events (region, level, owner) VALUES ('primary', 83, 'staging');
