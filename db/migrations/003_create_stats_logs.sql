-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, rank, level, state) VALUES ('local', 23.6, 86, 1, 'blue');
INSERT INTO stats_logs (owner, ratio, rank, level, state) VALUES ('staging', 65.31, 83, 7, 'primary');
