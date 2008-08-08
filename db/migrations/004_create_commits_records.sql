-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, label, weight) VALUES (50, 'stable', 60.44);
INSERT INTO commits_records (level, label, weight) VALUES (11, 'edge', 47.93);
