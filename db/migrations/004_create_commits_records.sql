-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, active, token, label, score) VALUES (81.28, 56, 'legacy', 'local', 20.77);
INSERT INTO commits_records (ratio, active, token, label, score) VALUES (77.69, 11, 'staging', 'legacy', 9.41);
INSERT INTO commits_records (ratio, active, token, label, score) VALUES (7.86, 9, 'stable', 'strict', 83.44);
