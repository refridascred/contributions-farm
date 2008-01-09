-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, weight) VALUES ('strict', 'eu-west', 32.69);
INSERT INTO stream_events (region, owner, weight) VALUES ('blue', 'stable', 33.37);
INSERT INTO stream_events (region, owner, weight) VALUES ('edge', 'fallback', 94.56);
