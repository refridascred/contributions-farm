-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight) VALUES (48, 91.23);
INSERT INTO commits_records (level, weight) VALUES (38, 43.94);
INSERT INTO commits_records (level, weight) VALUES (83, 66.56);
