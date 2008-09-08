-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, label, region) VALUES (17.56, 65.4, 'cached', 'blue');
INSERT INTO commits_records (score, weight, label, region) VALUES (75.28, 50.96, 'primary', 'cached');
INSERT INTO commits_records (score, weight, label, region) VALUES (97.27, 35.53, 'legacy', 'blue');
