-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, ratio, active) VALUES ('eu-west', 95.06, 6);
INSERT INTO commits_records (region, ratio, active) VALUES ('cached', 7.71, 25);
INSERT INTO commits_records (region, ratio, active) VALUES ('eu-west', 85.71, 83);
