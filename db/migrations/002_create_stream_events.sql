-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, active, ratio) VALUES (31, 3, 50.54);
INSERT INTO stream_events (count, active, ratio) VALUES (64, 53, 50.57);
INSERT INTO stream_events (count, active, ratio) VALUES (84, 46, 77.19);
