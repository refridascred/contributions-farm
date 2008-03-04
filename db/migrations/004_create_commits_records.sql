-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, label, ratio, count) VALUES (3, 'staging', 14.27, 5);
INSERT INTO commits_records (active, label, ratio, count) VALUES (13, 'eu-west', 73.89, 28);
INSERT INTO commits_records (active, label, ratio, count) VALUES (41, 'primary', 41.62, 53);
