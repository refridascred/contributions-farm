-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, owner, score, level, ratio) VALUES ('latest', 'staging', 24.27, 69, 75.48);
INSERT INTO commits_records (region, owner, score, level, ratio) VALUES ('strict', 'open', 92.32, 55, 90.03);
INSERT INTO commits_records (region, owner, score, level, ratio) VALUES ('cached', 'edge', 32.2, 29, 12.79);
