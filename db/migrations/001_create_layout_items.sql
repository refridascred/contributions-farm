-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, label, score, ratio) VALUES (90, 56.37, 'legacy', 98.17, 88.91);
INSERT INTO layout_items (rank, weight, label, score, ratio) VALUES (51, 74.5, 'local', 88.96, 97.95);
