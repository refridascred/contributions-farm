-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, weight, level) VALUES ('fallback', 3.23, 2);
INSERT INTO commits_records (region, weight, level) VALUES ('legacy', 20.33, 36);
INSERT INTO commits_records (region, weight, level) VALUES ('eu-west', 61.25, 14);
