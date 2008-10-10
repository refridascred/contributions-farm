-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, token, count, ratio) VALUES (93.11, 'stable', 89, 14.34);
INSERT INTO layout_items (weight, token, count, ratio) VALUES (96.33, 'strict', 91, 58.7);
INSERT INTO layout_items (weight, token, count, ratio) VALUES (16.18, 'edge', 78, 55.44);
