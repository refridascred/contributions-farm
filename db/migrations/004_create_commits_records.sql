-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, count, rank, token, ratio) VALUES ('fallback', 58, 86, 'blue', 30.03);
INSERT INTO commits_records (region, count, rank, token, ratio) VALUES ('open', 94, 9, 'edge', 72.18);
INSERT INTO commits_records (region, count, rank, token, ratio) VALUES ('cached', 24, 8, 'staging', 82.57);
