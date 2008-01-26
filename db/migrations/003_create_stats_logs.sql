-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, state, level, weight) VALUES ('cached', 98.99, 'edge', 12, 81.52);
INSERT INTO stats_logs (owner, ratio, state, level, weight) VALUES ('latest', 55.9, 'latest', 23, 90.83);
