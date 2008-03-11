-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, label, count, score, ratio) VALUES ('legacy', 'fallback', 21, 1.11, 66.14);
INSERT INTO commits_records (region, label, count, score, ratio) VALUES ('local', 'stable', 70, 55.64, 78.86);
INSERT INTO commits_records (region, label, count, score, ratio) VALUES ('eu-west', 'open', 51, 7.05, 34.94);
