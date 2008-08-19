-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, state, ratio, weight, rank) VALUES ('legacy', 'staging', 66.22, 2.8, 74);
INSERT INTO stats_logs (region, state, ratio, weight, rank) VALUES ('legacy', 'primary', 56.26, 54.56, 32);
INSERT INTO stats_logs (region, state, ratio, weight, rank) VALUES ('eu-west', 'latest', 16.49, 89.05, 27);
