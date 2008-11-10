-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, region, count) VALUES (85.69, 'local', 'standard', 54);
INSERT INTO commits_records (ratio, label, region, count) VALUES (90.3, 'legacy', 'local', 33);
INSERT INTO commits_records (ratio, label, region, count) VALUES (53.22, 'eu-west', 'standard', 66);
