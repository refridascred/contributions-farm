-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, weight, score) VALUES (71.92, 29.07, 76.57);
INSERT INTO commits_records (ratio, weight, score) VALUES (14.57, 45.62, 22.16);
INSERT INTO commits_records (ratio, weight, score) VALUES (29.41, 66.48, 44.53);
