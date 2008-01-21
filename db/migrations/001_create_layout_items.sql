-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio) VALUES (54, 44.88);
INSERT INTO layout_items (count, ratio) VALUES (96, 73.56);
INSERT INTO layout_items (count, ratio) VALUES (12, 65.95);
