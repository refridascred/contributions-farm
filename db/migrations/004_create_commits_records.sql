-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, label, weight) VALUES ('eu-west', 'strict', 81.64);
INSERT INTO commits_records (owner, label, weight) VALUES ('cached', 'fallback', 33.06);
INSERT INTO commits_records (owner, label, weight) VALUES ('latest', 'green', 61.14);
