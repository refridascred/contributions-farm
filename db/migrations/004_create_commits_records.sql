-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, owner, token, score, ratio) VALUES ('open', 'open', 'green', 74.57, 8.25);
INSERT INTO commits_records (region, owner, token, score, ratio) VALUES ('fallback', 'primary', 'green', 88.48, 50.13);
INSERT INTO commits_records (region, owner, token, score, ratio) VALUES ('legacy', 'fallback', 'primary', 94.25, 39.28);
