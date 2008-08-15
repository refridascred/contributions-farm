-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, ratio, score) VALUES (12, 92.07, 56.57);
INSERT INTO layout_items (rank, ratio, score) VALUES (1, 8.69, 19.04);
INSERT INTO layout_items (rank, ratio, score) VALUES (90, 70.94, 92.08);
