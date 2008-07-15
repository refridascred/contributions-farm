-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, level) VALUES (98.16, 11);
INSERT INTO commits_records (weight, level) VALUES (77.63, 68);
INSERT INTO commits_records (weight, level) VALUES (44.83, 92);
