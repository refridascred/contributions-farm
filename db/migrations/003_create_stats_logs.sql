-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, count, ratio, state, level) VALUES ('strict', 71, 24.49, 'local', 50);
INSERT INTO stats_logs (owner, count, ratio, state, level) VALUES ('eu-west', 49, 0.43, 'cached', 86);
