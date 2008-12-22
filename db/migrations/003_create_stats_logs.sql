-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, state) VALUES ('legacy', 97.74, 'local');
INSERT INTO stats_logs (owner, ratio, state) VALUES ('blue', 24.86, 'latest');
INSERT INTO stats_logs (owner, ratio, state) VALUES ('blue', 12.32, 'open');
