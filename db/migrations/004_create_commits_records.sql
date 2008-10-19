-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, active, rank) VALUES (68.95, 65, 69);
INSERT INTO commits_records (weight, active, rank) VALUES (27.68, 16, 49);
INSERT INTO commits_records (weight, active, rank) VALUES (16.89, 4, 59);
