-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level) VALUES (19.31, 78);
INSERT INTO commits_records (weight, level) VALUES (54.08, 81);
INSERT INTO commits_records (weight, level) VALUES (39.25, 69);
