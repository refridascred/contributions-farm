-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, ratio, count) VALUES ('green', 91.03, 1);
INSERT INTO layout_items (token, ratio, count) VALUES ('standard', 67.8, 74);
INSERT INTO layout_items (token, ratio, count) VALUES ('legacy', 76.94, 47);
