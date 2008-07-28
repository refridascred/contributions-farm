-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, region) VALUES (78.48, 'primary', 'green');
INSERT INTO commits_records (ratio, label, region) VALUES (63.75, 'staging', 'cached');
