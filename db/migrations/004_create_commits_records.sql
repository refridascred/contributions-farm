-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, token, score, weight) VALUES (78.45, 'fallback', 25.48, 66.01);
INSERT INTO commits_records (ratio, token, score, weight) VALUES (88.68, 'standard', 24.12, 47.97);
