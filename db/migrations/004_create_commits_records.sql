-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, weight, level, label, ratio) VALUES (68.92, 98.33, 39, 'standard', 57.77);
INSERT INTO commits_records (score, weight, level, label, ratio) VALUES (93.6, 64.81, 15, 'stable', 58.89);
