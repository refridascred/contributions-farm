-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, state, owner, weight) VALUES (35, 'primary', 'latest', 11.93);
INSERT INTO stats_logs (level, state, owner, weight) VALUES (27, 'latest', 'standard', 22.11);
