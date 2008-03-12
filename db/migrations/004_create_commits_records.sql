-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, owner, ratio, score, region) VALUES ('strict', 'staging', 9.33, 55.14, 'green');
INSERT INTO commits_records (token, owner, ratio, score, region) VALUES ('strict', 'strict', 95.01, 78.51, 'standard');
INSERT INTO commits_records (token, owner, ratio, score, region) VALUES ('primary', 'standard', 48.95, 4.8, 'local');
