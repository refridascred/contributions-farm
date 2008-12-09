-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, count, level, weight) VALUES ('stable', 65, 4, 62.55);
INSERT INTO commits_records (label, count, level, weight) VALUES ('edge', 16, 77, 30.52);
