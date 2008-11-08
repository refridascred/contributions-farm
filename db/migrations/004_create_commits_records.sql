-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, level, rank, weight) VALUES ('strict', 12, 57, 84.34);
INSERT INTO commits_records (label, level, rank, weight) VALUES ('fallback', 24, 4, 49.74);
