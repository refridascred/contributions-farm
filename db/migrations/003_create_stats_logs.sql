-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, score, owner, state, region) VALUES (27.26, 28.75, 'local', 'standard', 'fallback');
INSERT INTO stats_logs (weight, score, owner, state, region) VALUES (36.54, 62.1, 'primary', 'latest', 'latest');
INSERT INTO stats_logs (weight, score, owner, state, region) VALUES (97.77, 2.33, 'strict', 'stable', 'standard');
