-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, ratio, rank) VALUES ('stable', 56.42, 75);
INSERT INTO stats_logs (state, ratio, rank) VALUES ('open', 74.44, 67);
INSERT INTO stats_logs (state, ratio, rank) VALUES ('legacy', 87.07, 4);
