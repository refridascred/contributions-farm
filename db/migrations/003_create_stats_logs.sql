-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, state, owner, level) VALUES (39.11, 'open', 'eu-west', 56);
INSERT INTO stats_logs (weight, state, owner, level) VALUES (27.03, 'blue', 'blue', 96);
INSERT INTO stats_logs (weight, state, owner, level) VALUES (70.57, 'legacy', 'standard', 32);
