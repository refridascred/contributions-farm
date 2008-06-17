-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, token, weight, ratio, active) VALUES ('stable', 'standard', 79.61, 63.17, 14);
INSERT INTO commits_records (owner, token, weight, ratio, active) VALUES ('strict', 'standard', 98.23, 97.16, 47);
INSERT INTO commits_records (owner, token, weight, ratio, active) VALUES ('strict', 'blue', 94.47, 47.22, 82);
