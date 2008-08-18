-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, weight, score, label, ratio) VALUES ('local', 52.55, 86.82, 'cached', 56.78);
INSERT INTO commits_records (owner, weight, score, label, ratio) VALUES ('stable', 31.58, 20.22, 'stable', 6.62);
