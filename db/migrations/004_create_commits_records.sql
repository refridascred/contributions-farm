-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, count, level) VALUES (82.89, 'staging', 32, 37);
INSERT INTO commits_records (weight, label, count, level) VALUES (29.34, 'legacy', 19, 59);
