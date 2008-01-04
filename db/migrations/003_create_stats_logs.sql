-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, state, score, label, ratio) VALUES ('standard', 'blue', 3.16, 'cached', 95.87);
INSERT INTO stats_logs (region, state, score, label, ratio) VALUES ('staging', 'staging', 64.65, 'stable', 37.52);
