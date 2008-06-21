-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score, owner, state) VALUES (81.09, 3.89, 'primary', 'green');
INSERT INTO stats_logs (ratio, score, owner, state) VALUES (98.94, 36.2, 'edge', 'stable');
INSERT INTO stats_logs (ratio, score, owner, state) VALUES (86.99, 87.88, 'open', 'green');
