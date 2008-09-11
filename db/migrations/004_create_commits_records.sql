-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, level, ratio) VALUES ('fallback', 57, 72.02);
INSERT INTO commits_records (region, level, ratio) VALUES ('strict', 21, 90.91);
