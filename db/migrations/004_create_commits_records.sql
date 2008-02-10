-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, active, ratio, score) VALUES ('eu-west', 83, 92.8, 43.35);
INSERT INTO commits_records (label, active, ratio, score) VALUES ('strict', 90, 95.41, 62.98);
INSERT INTO commits_records (label, active, ratio, score) VALUES ('cached', 5, 53.16, 80.31);
