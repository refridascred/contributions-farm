-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, level, weight, active, region) VALUES ('eu-west', 94, 46.81, 70, 'primary');
INSERT INTO stats_logs (state, level, weight, active, region) VALUES ('green', 16, 70.4, 80, 'blue');
INSERT INTO stats_logs (state, level, weight, active, region) VALUES ('green', 69, 53.56, 99, 'stable');
