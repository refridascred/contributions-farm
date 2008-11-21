-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, score, rank, weight) VALUES (81, 15.12, 77, 41.45);
INSERT INTO layout_items (count, score, rank, weight) VALUES (76, 90.39, 39, 64.12);
INSERT INTO layout_items (count, score, rank, weight) VALUES (8, 7.49, 49, 85.65);
