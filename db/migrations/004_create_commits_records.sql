-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, score, ratio) VALUES ('primary', 69.41, 12.21);
INSERT INTO commits_records (region, score, ratio) VALUES ('local', 12.79, 82.66);
