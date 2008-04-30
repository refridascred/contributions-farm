-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, ratio) VALUES ('latest', 69, 56.1);
INSERT INTO commits_records (region, level, ratio) VALUES ('primary', 31, 88.06);
INSERT INTO commits_records (region, level, ratio) VALUES ('strict', 9, 24.91);
