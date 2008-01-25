-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, token, weight, level) VALUES (39.08, 'stable', 42.97, 65);
INSERT INTO commits_records (score, token, weight, level) VALUES (41.27, 'fallback', 24.68, 94);
