-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, weight, region, label) VALUES (78, 66.66, 'legacy', 'cached');
INSERT INTO commits_records (level, weight, region, label) VALUES (73, 71.07, 'primary', 'staging');
INSERT INTO commits_records (level, weight, region, label) VALUES (13, 22.26, 'strict', 'legacy');
