-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, level, ratio) VALUES (12.47, 28, 17.36);
INSERT INTO commits_records (score, level, ratio) VALUES (23.85, 48, 77.32);
INSERT INTO commits_records (score, level, ratio) VALUES (78.54, 50, 58.23);
