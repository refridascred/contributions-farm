-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, level, weight, state) VALUES (11.57, 17, 73.05, 'legacy');
INSERT INTO stats_logs (score, level, weight, state) VALUES (98.96, 20, 68.93, 'staging');
INSERT INTO stats_logs (score, level, weight, state) VALUES (43.39, 84, 93.44, 'standard');
