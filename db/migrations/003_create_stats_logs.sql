-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, weight, owner, state, region) VALUES (18, 63.4, 'local', 'latest', 'fallback');
INSERT INTO stats_logs (level, weight, owner, state, region) VALUES (10, 74.48, 'blue', 'cached', 'cached');
INSERT INTO stats_logs (level, weight, owner, state, region) VALUES (72, 41.75, 'open', 'primary', 'latest');
