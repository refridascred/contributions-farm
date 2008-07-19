-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, ratio) VALUES (91, 88.52);
INSERT INTO stream_events (level, ratio) VALUES (91, 36.94);
INSERT INTO stream_events (level, ratio) VALUES (52, 10.0);
