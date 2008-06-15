-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, level, weight) VALUES ('open', 81, 75.77);
INSERT INTO commits_records (label, level, weight) VALUES ('edge', 68, 35.74);
INSERT INTO commits_records (label, level, weight) VALUES ('green', 13, 46.61);
