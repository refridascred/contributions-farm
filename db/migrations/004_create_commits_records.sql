-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, region, score, count) VALUES ('standard', 'cached', 72.61, 63);
INSERT INTO commits_records (token, region, score, count) VALUES ('cached', 'latest', 63.25, 45);
