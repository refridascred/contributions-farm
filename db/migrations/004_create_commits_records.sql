-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, label, token, ratio, weight) VALUES ('blue', 'latest', 'open', 36.3, 95.8);
INSERT INTO commits_records (owner, label, token, ratio, weight) VALUES ('edge', 'strict', 'open', 22.22, 86.64);
INSERT INTO commits_records (owner, label, token, ratio, weight) VALUES ('staging', 'latest', 'latest', 42.77, 47.16);
