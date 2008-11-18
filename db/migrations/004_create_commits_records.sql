-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, region, score, weight) VALUES ('blue', 'legacy', 39.23, 36.94);
INSERT INTO commits_records (token, region, score, weight) VALUES ('blue', 'stable', 49.18, 87.46);
INSERT INTO commits_records (token, region, score, weight) VALUES ('cached', 'cached', 23.97, 39.85);
