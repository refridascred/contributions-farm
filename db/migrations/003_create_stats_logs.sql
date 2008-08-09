-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, active, state, rank, count) VALUES (14.96, 56, 'cached', 87, 91);
INSERT INTO stats_logs (ratio, active, state, rank, count) VALUES (59.98, 18, 'staging', 17, 51);
INSERT INTO stats_logs (ratio, active, state, rank, count) VALUES (38.13, 97, 'eu-west', 31, 4);
