-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, count, rank, label, weight) VALUES ('open', 46, 9, 'green', 9.41);
INSERT INTO commits_records (state, count, rank, label, weight) VALUES ('eu-west', 4, 85, 'open', 11.59);
