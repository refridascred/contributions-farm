-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, token, rank, count) VALUES (83.74, 'blue', 68, 11);
INSERT INTO layout_items (weight, token, rank, count) VALUES (6.68, 'cached', 79, 30);
INSERT INTO layout_items (weight, token, rank, count) VALUES (32.19, 'open', 28, 53);
