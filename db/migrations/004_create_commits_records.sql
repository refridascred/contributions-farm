-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, label, level) VALUES (4.55, 'primary', 92);
INSERT INTO commits_records (score, label, level) VALUES (97.22, 'staging', 40);
INSERT INTO commits_records (score, label, level) VALUES (28.15, 'fallback', 23);
