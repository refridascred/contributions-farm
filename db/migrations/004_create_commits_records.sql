-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, count, ratio) VALUES (74.06, 51, 40.89);
INSERT INTO commits_records (score, count, ratio) VALUES (48.55, 11, 52.25);
INSERT INTO commits_records (score, count, ratio) VALUES (84.22, 55, 14.62);
