-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, owner, level, label, weight) VALUES (75.54, 'eu-west', 46, 'blue', 85.27);
INSERT INTO commits_records (ratio, owner, level, label, weight) VALUES (44.27, 'primary', 35, 'legacy', 70.05);
