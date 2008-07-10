-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, level, rank, weight, owner) VALUES ('fallback', 79, 87, 52.35, 'open');
INSERT INTO commits_records (label, level, rank, weight, owner) VALUES ('eu-west', 81, 0, 80.94, 'edge');
INSERT INTO commits_records (label, level, rank, weight, owner) VALUES ('eu-west', 93, 56, 57.65, 'staging');
