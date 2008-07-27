-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, ratio, weight, label) VALUES ('primary', 33.67, 63.24, 'open');
INSERT INTO commits_records (region, ratio, weight, label) VALUES ('local', 91.76, 60.42, 'open');
INSERT INTO commits_records (region, ratio, weight, label) VALUES ('legacy', 98.02, 34.71, 'open');
