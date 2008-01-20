-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, active, ratio) VALUES (68.43, 63, 17.22);
INSERT INTO commits_records (weight, active, ratio) VALUES (95.58, 12, 43.92);
INSERT INTO commits_records (weight, active, ratio) VALUES (53.09, 95, 41.98);
