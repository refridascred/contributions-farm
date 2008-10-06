-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, count, ratio) VALUES ('green', 72, 84.17);
INSERT INTO layout_items (token, count, ratio) VALUES ('edge', 7, 5.28);
INSERT INTO layout_items (token, count, ratio) VALUES ('legacy', 51, 60.26);
