-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, rank, state, level) VALUES (98.87, 64, 'local', 88);
INSERT INTO stats_logs (ratio, rank, state, level) VALUES (89.38, 94, 'open', 90);
INSERT INTO stats_logs (ratio, rank, state, level) VALUES (34.29, 18, 'local', 86);
