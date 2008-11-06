-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, rank) VALUES (75, 83);
INSERT INTO layout_items (count, rank) VALUES (64, 50);
INSERT INTO layout_items (count, rank) VALUES (8, 72);
