-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, region, count, ratio) VALUES ('strict', 'stable', 18, 38.46);
INSERT INTO commits_records (token, region, count, ratio) VALUES ('staging', 'stable', 68, 55.49);
INSERT INTO commits_records (token, region, count, ratio) VALUES ('edge', 'open', 92, 34.93);
