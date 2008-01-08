-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio, rank, level, state) VALUES ('strict', 10.24, 13, 53, 'edge');
INSERT INTO commits_records (label, ratio, rank, level, state) VALUES ('legacy', 83.97, 99, 46, 'cached');
INSERT INTO commits_records (label, ratio, rank, level, state) VALUES ('primary', 24.46, 33, 91, 'latest');
