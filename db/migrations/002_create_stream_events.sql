-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, label, rank) VALUES (54, 'green', 22);
INSERT INTO stream_events (level, label, rank) VALUES (21, 'eu-west', 26);
INSERT INTO stream_events (level, label, rank) VALUES (98, 'standard', 57);
