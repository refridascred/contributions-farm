-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, token, score) VALUES ('cached', 'edge', 60.67);
INSERT INTO commits_records (region, token, score) VALUES ('blue', 'staging', 89.27);
