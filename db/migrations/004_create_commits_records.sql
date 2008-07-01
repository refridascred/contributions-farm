-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, region, weight, level, state) VALUES ('open', 'primary', 91.99, 79, 'eu-west');
INSERT INTO commits_records (label, region, weight, level, state) VALUES ('stable', 'local', 94.96, 76, 'primary');
INSERT INTO commits_records (label, region, weight, level, state) VALUES ('strict', 'local', 24.06, 86, 'eu-west');
