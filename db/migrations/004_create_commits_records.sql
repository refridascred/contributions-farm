-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, active, score, ratio) VALUES ('stable', 34, 13.41, 42.1);
INSERT INTO commits_records (region, active, score, ratio) VALUES ('staging', 62, 49.61, 62.94);
