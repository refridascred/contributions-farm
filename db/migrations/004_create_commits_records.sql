-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, rank, ratio, label) VALUES ('primary', 57, 91.86, 'blue');
INSERT INTO commits_records (region, rank, ratio, label) VALUES ('primary', 62, 94.95, 'stable');
