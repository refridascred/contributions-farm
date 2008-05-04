-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active, level, region, ratio) VALUES (54.89, 12, 59, 'cached', 64.92);
INSERT INTO commits_records (score, active, level, region, ratio) VALUES (77.88, 4, 85, 'eu-west', 71.98);
INSERT INTO commits_records (score, active, level, region, ratio) VALUES (97.39, 48, 45, 'fallback', 67.33);
