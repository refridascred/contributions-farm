-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, count) VALUES (61.32, 'latest', 81);
INSERT INTO layout_items (weight, token, count) VALUES (71.74, 'edge', 32);
INSERT INTO layout_items (weight, token, count) VALUES (81.47, 'cached', 54);
