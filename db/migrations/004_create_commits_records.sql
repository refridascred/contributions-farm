-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, weight, level) VALUES ('stable', 89.19, 76);
INSERT INTO commits_records (label, weight, level) VALUES ('standard', 11.26, 74);
INSERT INTO commits_records (label, weight, level) VALUES ('open', 18.17, 86);
