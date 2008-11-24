-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, score, weight, rank, ratio) VALUES ('blue', 24.51, 33.05, 93, 47.14);
INSERT INTO layout_items (owner, score, weight, rank, ratio) VALUES ('open', 49.29, 77.98, 95, 86.84);
INSERT INTO layout_items (owner, score, weight, rank, ratio) VALUES ('latest', 22.11, 15.27, 1, 34.64);
