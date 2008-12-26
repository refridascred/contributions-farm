-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, region, score, level) VALUES (95.62, 'fallback', 69.13, 64);
INSERT INTO commits_records (ratio, region, score, level) VALUES (75.57, 'cached', 97.4, 69);
INSERT INTO commits_records (ratio, region, score, level) VALUES (47.89, 'eu-west', 65.71, 22);
