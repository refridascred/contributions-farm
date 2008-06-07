-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, region, label, level, ratio) VALUES (30, 'edge', 'fallback', 90, 52.7);
INSERT INTO commits_records (rank, region, label, level, ratio) VALUES (15, 'staging', 'blue', 4, 60.79);
INSERT INTO commits_records (rank, region, label, level, ratio) VALUES (99, 'fallback', 'standard', 51, 87.89);
