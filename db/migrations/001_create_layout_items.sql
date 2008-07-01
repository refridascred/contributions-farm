-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, rank, token, count) VALUES (2.38, 10, 'local', 61);
INSERT INTO layout_items (weight, rank, token, count) VALUES (1.02, 3, 'legacy', 11);
INSERT INTO layout_items (weight, rank, token, count) VALUES (74.32, 12, 'eu-west', 27);
