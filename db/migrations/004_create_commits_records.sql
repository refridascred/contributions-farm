-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, ratio, region, weight) VALUES (90, 30.9, 'legacy', 15.97);
INSERT INTO commits_records (active, ratio, region, weight) VALUES (39, 45.77, 'standard', 60.06);
