-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, level, ratio) VALUES (10.48, 65, 22.04);
INSERT INTO commits_records (score, level, ratio) VALUES (81.47, 40, 12.85);
