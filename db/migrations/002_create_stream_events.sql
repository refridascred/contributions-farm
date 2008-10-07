-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, count, active, rank) VALUES ('legacy', 70, 95, 60);
INSERT INTO stream_events (owner, count, active, rank) VALUES ('cached', 56, 82, 17);
INSERT INTO stream_events (owner, count, active, rank) VALUES ('eu-west', 13, 88, 41);
