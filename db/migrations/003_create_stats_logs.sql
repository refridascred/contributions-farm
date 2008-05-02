-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, score, rank, region, state) VALUES ('local', 75.23, 90, 'green', 'strict');
INSERT INTO stats_logs (owner, score, rank, region, state) VALUES ('cached', 71.48, 84, 'blue', 'stable');
INSERT INTO stats_logs (owner, score, rank, region, state) VALUES ('local', 6.23, 53, 'primary', 'latest');
