-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, level, weight) VALUES ('strict', 2, 82.84);
INSERT INTO commits_records (label, level, weight) VALUES ('blue', 20, 55.49);
