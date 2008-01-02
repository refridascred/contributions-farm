-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, score, rank, ratio, region) VALUES ('fallback', 28.43, 17, 76.62, 'legacy');
INSERT INTO commits_records (token, score, rank, ratio, region) VALUES ('legacy', 81.83, 27, 19.99, 'green');
INSERT INTO commits_records (token, score, rank, ratio, region) VALUES ('local', 65.1, 46, 64.64, 'primary');
